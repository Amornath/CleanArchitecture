using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork unitOfWork;
        public MovieService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public List<Movie> GetAllMovies()
        {
            var movies = (from m in unitOfWork.Movies.Get()
                         select new Movie
                         {
                             ID= m.ID,
                             Name= m.Name,
                         }).ToList();
            return movies;
        }
    }
}
