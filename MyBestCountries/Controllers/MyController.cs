using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBestCountries.Data;

namespace MyBestCountries.Controllers
{
    public class MyController : Controller
    {
        private IMyCountriesRepository _repository;

        public MyController(IMyCountriesRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}