﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
            portfolioContext.Experiences.Add(experience);
            portfolioContext.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
        public IActionResult DeleteExperience(int id)
        {
            var value = portfolioContext.Experiences.Find(id);
            portfolioContext.Experiences.Remove(value);
            portfolioContext.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
			var value = portfolioContext.Experiences.Find(id);
            return View(value);
		}
		[HttpPost]
		public IActionResult EditExperience(Experience experience)
		{
			portfolioContext.Experiences.Update(experience);
            portfolioContext.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
