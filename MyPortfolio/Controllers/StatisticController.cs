﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext portfolioContext = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = portfolioContext.Skills.Count();
			ViewBag.v2 = portfolioContext.Experiences.Count();
			ViewBag.v3 = portfolioContext.Testimonials.Count();
			ViewBag.v4 = portfolioContext.SocialMedias.Count();
			return View();
		}
	}
}
