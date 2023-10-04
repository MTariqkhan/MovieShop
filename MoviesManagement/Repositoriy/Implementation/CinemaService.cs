using System;
using MoviesManagement.Models.Domain;
using MoviesManagement.Repositoriy.Abstraction;

namespace MoviesManagement.Repositoriy.Implementation
{
	public class CinemaService : ICinemaService
    {
        private readonly DatabaseContext _databaseContext;
		public CinemaService(DatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
        }

        public bool Add(Cinema model)
        {
            _databaseContext.Cinema.Add(model);
            _databaseContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var cinema = GetById(id);
            _databaseContext.Cinema.Remove(cinema);
            _databaseContext.SaveChanges();
            return true;
        }

        public Cinema GetById(int id)
        {
            var cinema = _databaseContext.Cinema.Find(id);
            return cinema;
        }

        public bool Update(Cinema model)
        {
            _databaseContext.Cinema.Update(model);
            _databaseContext.SaveChanges();
            return true;
        }
    }
}





//bool Add(Cinema model);
//bool Update(Cinema model);
//Cinema GetById(int id);
//bool Delete(int id);