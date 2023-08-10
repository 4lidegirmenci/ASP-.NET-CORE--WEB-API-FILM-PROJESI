using Entities.Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Contracts;
using Repositories.Conracts;
using Entities.Exceptions;
using AutoMapper;
using Entities.DataTransferObject;
using Entities.RequestFeatures;

namespace Services
{
    public class FilmManager : IFilmServices
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public FilmManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public FilmDto CreateOneFilm(FilmDtoForInsertion filmDto)
        {
            var entity = _mapper.Map<Film>(filmDto);
            _manager.Film.CreateOneFilm(entity);
            _manager.Save();
            return _mapper.Map<FilmDto>(entity);
        }

        public void DeleteOneFilm(int id, bool trackChanges)
        {
            //check entity

            var entity = _manager.Film.GetOneFilmById(id, trackChanges);
            if (entity is null)
            {
                throw new FilmNotFoundException(id);
            }
            _manager.Film.DeleteOneFilm(entity);
            _manager.Save();
        }

        public (IEnumerable<FilmDto> films, MetaData metaData) GetAllFilms(FilmParameters filmParameters,bool trackChanges)
        {
            if (!filmParameters.ValidImdbRange)
            {
                throw new IMDBOutofRangeBadRequestException();
            }

            var filmsWithMetaData = _manager.Film.GetAllFilms(filmParameters,trackChanges);
            var filmsDto=_mapper.Map<IEnumerable<FilmDto>>(filmsWithMetaData);
            return (filmsDto, filmsWithMetaData.MetaData);
        }

        public FilmDto GetFilmById(int id, bool trackChanges)
        {
            var film = _manager.Film.GetOneFilmById(id, trackChanges);
            if (film is null)
            {
                throw new FilmNotFoundException(id);
            }
            return _mapper.Map<FilmDto>(film);
        }

        public void UpdateoneBook(int id, FilmDtoForUpdate filmdto, bool trackChanges)
        {
            //check entity
            var entity = _manager.Film.GetOneFilmById(id, trackChanges);
            if (entity is null)
            {
                throw new FilmNotFoundException(id);
            }
            //check params

            //entity.Name = film.Name;
            //entity.Type = film.Type;
            //entity.IMDB = film.IMDB;

            //mapping

            entity = _mapper.Map<Film>(filmdto);

            _manager.Film.Update(entity);
            _manager.Save();

        }
    }
}
