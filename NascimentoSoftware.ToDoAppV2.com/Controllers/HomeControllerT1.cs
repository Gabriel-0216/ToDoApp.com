﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NascimentoSoftware.ToDoAppV2.com.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NascimentoSoftware.ToDoAppV2.com.Controllers
{
    public class HomeControllerT1 : Controller
    {
        private readonly ILogger<HomeControllerT1> _logger;

        public HomeControllerT1(ILogger<HomeControllerT1> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
