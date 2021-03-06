using DependencyInjectionServices.Interfaces;
using DependencyInjectionServices.Models;
using DependencyInjectionServices.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionServices.Controllers
{
   
    public class DIController : Controller
    {
        private  ISingletonService _singletonService;
        private  IScopedService _scopedService;
        private  ITransientService _transientService;

        public DIController(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }
        //public DIController(IServiceProvider serviceProvider)
        //{
        //    _singletonService = serviceProvider.GetRequiredService<ISingletonService>();
        //    _scopedService = serviceProvider.GetRequiredService<IScopedService>();
        //    _transientService = serviceProvider.GetRequiredService<ITransientService>();
        //}

        public IActionResult Index()
        {
            var model = new DIModel();
            model.SingletonTime = _singletonService.Time;
            model.ScopedTime = _scopedService.Time;
            model.TransientTime = _transientService.Time;

            return View(model);
        }
    }
}
