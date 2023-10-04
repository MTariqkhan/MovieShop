using System;
using MoviesManagement.Models.Domain;

namespace MoviesManagement.Repositoriy.Abstraction
{
	public interface ICinemaService
	{
        bool Add(Cinema model);
        bool Update(Cinema model);
        Cinema GetById(int id);
        bool Delete(int id);
        IQueryable<Cinema> List();
    }
}

