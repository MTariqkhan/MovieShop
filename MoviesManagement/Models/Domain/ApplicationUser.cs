using System;
using Microsoft.AspNetCore.Identity;

namespace MoviesManagement.Models.Domain
{
	public class ApplicationUser : IdentityUser
	{
		public string? Name { get; set; }
	}
}

	