using System;
using MoviesManagement.Models.Domain;

namespace MoviesManagement.Repositoriy.Abstraction
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        Genre GetById(int id);
        bool Delete(int id);
        IQueryable<Genre> List();

    }
}

