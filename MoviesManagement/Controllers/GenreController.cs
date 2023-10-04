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
    [Authorize(Roles = "Admin")]
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Genre model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = _genreService.Add(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(GenreList));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }
        }

        public IActionResult Edit(int id)
        {
            var data = _genreService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Genre model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = _genreService.Update(model);
            if (result)
            {
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction(nameof(GenreList));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }
        }

        public IActionResult GenreList()
        {
            var data = this._genreService.List().ToList();
            return View(data);
        }

        public IActionResult Delete(int id)
        {
            var result = _genreService.Delete(id);
            TempData["msg"] = "Deleted Successfully";
            return RedirectToAction(nameof(GenreList));
        }
    }
}