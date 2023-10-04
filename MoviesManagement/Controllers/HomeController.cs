using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Repositoriy.Abstraction;

namespace MoviesManagement.Controllers;


public class HomeController : Controller
{
    
    private readonly IMovieService _movieService;
    public HomeController(IMovieService movieService)
    {
        _movieService = movieService;
    }
    public IActionResult Index(string term = "", int currentPage = 1)
    {
        var movies = _movieService.List(term, true, currentPage);
        return View(movies);
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult MovieDetail(int Id)
    {
        var movie = _movieService.GetById(Id);
        return View(movie);
    }

    public IActionResult NotAuthorized()
    {
        return View();
    }

}

