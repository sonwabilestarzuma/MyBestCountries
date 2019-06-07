using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBestCountries.Data;
using MyBestCountries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBestCountries.Controllers
{
    public class UserController : Controller
    {
        private IMyCountriesRepository _repository;
        private UserManager<ApplicationUser> _userManager;

        public UserController(IMyCountriesRepository repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }
        [HttpGet("{username}", Name = "UserVisits")]
        public async Task<ActionResult> Visits(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var visits = await _repository.GetVisitsByUserNameAsync(username);

            return View(visits);
        }
    }
}
