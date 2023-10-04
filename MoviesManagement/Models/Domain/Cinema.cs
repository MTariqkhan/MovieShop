using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesManagement.Models.Domain
{
	public class Cinema
	{
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public double Latitude { get; set; } 

        [Required]
        public double Longitude { get; set; }
    }
}

