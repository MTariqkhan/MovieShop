using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Repositoriy.Abstraction;

namespace MoviesManagement.Controllers;

public class HomeController : Controller
{
    private readonly IMovieService movieObject;

    public HomeController(IMovieService movieObject)
    {
        this.movieObject = movieObject;
    }

    public IActionResult Index()
    {
        var movies = movieObject.List();
        return View(movies);
    }

    public IActionResult About()
    {
        return View();
    }
}

