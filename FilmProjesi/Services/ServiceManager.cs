using AutoMapper;
using Repositories.Conracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IFilmServices> _filmService;
        private readonly Lazy<IUserServices> _userService;
        public ServiceManager(IRepositoryManager repositoryManager,ILoggerService logger,IMapper mapper)
        {
            _filmService = new Lazy<IFilmServices>(() => new FilmManager(repositoryManager,logger,mapper));
            _userService=new Lazy<IUserServices>(()=>new UserManager(repositoryManager, logger, mapper));

        }
        public IFilmServices FilmServices => _filmService.Value;

        public IUserServices UserServices => _userService.Value;
    }

}
