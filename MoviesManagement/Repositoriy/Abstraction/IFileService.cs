using System;
namespace MoviesManagement.Repositoriy.Abstraction
{
    public interface IFileService
    {
        public Tuple<int, string> SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
    }
}

