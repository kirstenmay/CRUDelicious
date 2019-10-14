using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            //Query to get all dishes in the database
            List<Dish> AllDishes = dbContext.Dish.ToList();
            AllDishes.Reverse();
            return View(AllDishes);
        }

        public IActionResult NewDish()
        {
            //Display form to add dish
            return View();
        }

        public IActionResult Create(Dish dish)
        {
            //Add dish to database
            if(ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewDish");
            }
        }

        [HttpGet("/Home/ViewDish/{dishId}")]
        public IActionResult ViewDish(int dishId)
        {
            //Get a specific dish from the database
            Dish thisDish = dbContext.Dish.FirstOrDefault(d => d.DishId == dishId);
            return View(thisDish);
        }

        [HttpGet("/Home/EditDish/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            //Get the specific dish from the database for form
            Dish editDish = dbContext.Dish.FirstOrDefault(ed => ed.DishId == dishId);
            return View(editDish);
        }
        [HttpPost("/Home/Edit/{id}")]
        public IActionResult Edit(InputUpdateModel dish, int id)
        {
            //Get dish from database and change it, save
            if(ModelState.IsValid)
            {
                Dish thisDish = dbContext.Dish.FirstOrDefault(d => d.DishId == id);
                thisDish.Name = dish.Name;
                thisDish.Chef = dish.Chef;
                thisDish.Calories = dish.Calories;
                thisDish.Tastiness = dish.Tastiness;
                thisDish.Description = dish.Description;
                thisDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("ViewDish", new {dishId = thisDish.DishId});
            }
            else
            {
                Dish thisDish = dbContext.Dish.FirstOrDefault(d => d.DishId == id);
                return View("EditDish", thisDish);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
