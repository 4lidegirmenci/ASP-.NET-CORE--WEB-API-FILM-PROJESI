using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Conracts
{
    public interface IFilmRepository:IRepositoryBase<Film>
    {
        PagedList<Film> GetAllFilms(FilmParameters filmParameters,bool trackChanges);

        Film GetOneFilmById(int id, bool trackChanges);

        void CreateOneFilm(Film film);

        void UpdateOneFilm(Film film);

        void DeleteOneFilm(Film film);
    }
}
