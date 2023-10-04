using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Models.Domain;
using MoviesManagement.Repositoriy.Abstraction;

namespace MoviesManagement.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CinemaController : Controller
    {
        private readonly ICinemaService _cinemaService;

        public CinemaController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        public IActionResult Index()
        {
            var data = _cinemaService.List().ToList();
            return View(data);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Cinema model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result  = _cinemaService.Add(model);

            if (result)
            {
                TempData["msg"] = "Cinema is added successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }
        }

        public IActionResult Edit(int Id)
        {
            var model = _cinemaService.GetById(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Cinema model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = _cinemaService.Update(model);

            if (result)
            {
                TempData["msg"] = "Cinema is updated successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }

        }

        public IActionResult Delete(int Id)
        {
            _cinemaService.Delete(Id);
            TempData["msg"] = "Cinema is Deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}

