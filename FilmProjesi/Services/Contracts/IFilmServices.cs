using Entities.DataTransferObject;
using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IFilmServices
    {
        (IEnumerable<FilmDto> films,MetaData metaData) GetAllFilms(FilmParameters filmParameters,bool trackChanges);

        FilmDto GetFilmById(int id,bool trackChanges);

        FilmDto CreateOneFilm(FilmDtoForInsertion film);

        void UpdateoneBook(int id,FilmDtoForUpdate filmdto,bool trackChanges);

        void DeleteOneFilm(int id,bool trackChanges);
    }
}
