using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class ExperienceController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();
        // GET: /<controller>/

        public IActionResult Index()
        {
           
            List<Experience> model = db.Experiences.ToList();
            return View(model);

        }
        public IActionResult Details(int id)
        {
            var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
            //var testList = thisExperience.ExperiencesPersons.Count();
            var PersonList = new List<Person>();
            //List<ExperiencesPersons> info = db.ExperiencesPersons
            //    .Include(ep => ep.Experience)
            //    .ThenInclude(ex => ex.Persons)
            //    .Where(ep => ep.ExperienceId == id)
            //    .ToList();
            //Experience selectedExperience = info[0].Experience;
            foreach (var person in thisExperience.ExperiencesPersons.ToList())
            {
                if (person.ExperienceId == id)
                {
                    PersonList.Add(person.Person);
                }
            }
            ViewBag.PersonsList = PersonList;
            return View(thisExperience);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            db.Experiences.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
