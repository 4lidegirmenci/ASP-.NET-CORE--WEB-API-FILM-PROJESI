using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Extensions
{
    public static class FilmRepositoryExtensions
    {
        public static IQueryable<Film> FilterFilms(this IQueryable<Film> films, uint minImdb, uint maxImdb) =>
            films.Where(film =>
            (film.IMDB >= minImdb)&&
            (film.IMDB <= maxImdb));
        
        public static IQueryable<Film> Search(this IQueryable<Film> films, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return films;
            }
            var lowerCase=searchTerm.Trim().ToLower();
            return films.Where(b => b.Name.ToLower().Contains(searchTerm));
             
        }
        
        
    }
}
