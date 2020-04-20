using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filmania.Mvc.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace Filmania.Mvc.Controllers
{
    public class FilmsController : Controller
    {
        private readonly FilmsDbContext _db;

        public FilmsController(FilmsDbContext db)
        {
            _db = db;
        }

        [Route("Films")]
        public IActionResult ListAllFilms()
        {
            var allFilms = _db.Films.ToList();
            return View(allFilms);
        }

        [Route("Films/Create")]
        public IActionResult CreateFilm()
        {
            var newFilm = new Film { Title = "MIB", Description = "Some B Shit" };
            var newFilm2 = new Film { Title = "MIB2", Description = "Some B Shit2" };
            _db.Films.Add(newFilm);
            _db.Films.Add(newFilm2);

            _db.SaveChanges();

            return Ok();
        }
    }
}