using System;
using MoviesManagement.Models.Domain;
using MoviesManagement.Models.DTO;

namespace MoviesManagement.Repositoriy.Abstraction
{
    public interface IMovieService
    {
        bool Add(Movie model);
        bool Update(Movie model);
        Movie GetById(int id);
        bool Delete(int id);
        MovieListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetGenreByMovieId(int movieId);

    }
}

