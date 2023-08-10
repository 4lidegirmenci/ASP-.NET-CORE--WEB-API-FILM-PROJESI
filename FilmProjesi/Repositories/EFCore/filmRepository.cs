using Entities.Models;
using Entities.RequestFeatures;
using Repositories.Conracts;
using Repositories.EFCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public sealed class filmRepository : RepositoryBase<Film>, IFilmRepository
    {
        public filmRepository(RepsitoryContext.RepositoryContext context) : base(context)
        {

        }

        public void CreateOneFilm(Film film)=>Create(film);
        

        public void DeleteOneFilm(Film film)=>Delete(film);


        public PagedList<Film> GetAllFilms(FilmParameters filmParameters, bool trackChanges)
        {
           var films= FindAll(trackChanges).FilterFilms(filmParameters.MinImdb,filmParameters.MaxImdb).Search(filmParameters.SearchTerm).OrderBy(b => b.Id).ToList();

            return PagedList<Film>.ToPagedList(films, filmParameters.PageNumber, filmParameters.PageSize);
        }


        public Film GetOneFilmById(int id, bool trackChanges) => FindByCondition(b => b.Id.Equals(id), trackChanges).SingleOrDefault();
        

        public void UpdateOneFilm(Film film)=>Update(film);
        
    }
}
