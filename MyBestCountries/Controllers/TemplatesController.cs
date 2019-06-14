using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCountriees.Hacks;

namespace MyBestCountries.Controllers
{
    public class TemplatesController : Controller
    {
        private List<SelectListItem> _selectCountriesList;

    
        public TemplatesController()
        {
            _selectCountriesList = Country.List.Select(c => new SelectListItem() { Text = c.Name }).ToList();
        }

        public ActionResult NewVisit()
        {
            ViewBag.Countries = _selectCountriesList;
            return View();
        }

        public ActionResult EditVisit()
        {
            ViewBag.Countries = _selectCountriesList;
            return View();
        }

        public ActionResult MyVisits()
        {
            return View();
        }
    }
}