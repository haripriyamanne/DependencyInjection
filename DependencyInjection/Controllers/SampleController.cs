using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class SampleController : Controller
    {
        private readonly SampleModel _sample;

        //public SampleController(IOptions<SampleModel> settingsOptions)
        //{
        //    _sample = settingsOptions.Value;
        //}
        public SampleController(IOptions<SampleModel> settingsOptions)
        {
           _sample = settingsOptions.Value;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = _sample.Title;
            ViewData["Updates"] = _sample.Updates;
            return View();
        }
    }
}
