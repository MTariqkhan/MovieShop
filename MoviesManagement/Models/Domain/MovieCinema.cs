using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesManagement.Models.Domain
{
	public class MovieCinema
	{
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public int CinemaId { get; set; }

        public Movie? Movie { get; set; }
        public Cinema? Cinema { get; set; }
    }
}
