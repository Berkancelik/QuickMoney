﻿using Microsoft.AspNetCore.Mvc;

namespace QuickMoney.Controllers
{
	public class MyProfileController : Controller
	{
		 
			public IActionResult Index()
			{
				return View();
			}
		}
	}