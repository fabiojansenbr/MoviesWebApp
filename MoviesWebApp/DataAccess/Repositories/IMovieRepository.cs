﻿using MoviesWebApp.Models;
using System.Collections.Generic;

namespace MoviesWebApp.DataAccess.Repositories
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        Movie GetMovieById(int id);
        IEnumerable<Movie> GetMovies();
        IEnumerable<Movie> GetMovies(int skip, int take);
    }
}
