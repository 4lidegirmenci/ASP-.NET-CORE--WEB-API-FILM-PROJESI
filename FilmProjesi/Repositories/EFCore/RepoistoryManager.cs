using Repositories.Conracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Repositories.EFCore.RepsitoryContext;


namespace Repositories.EFCore
{
    public class RepoistoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly Lazy<IFilmRepository> _filmRepository;
        private readonly Lazy<IUserRepository> _userRepository;

        public RepoistoryManager(RepositoryContext context)
        {
            _context = context;
            _filmRepository = new Lazy<IFilmRepository>(() => new filmRepository(_context));
            _userRepository = new Lazy<IUserRepository>(() => new userRepository(_context));
        }
        
        public IFilmRepository Film=>_filmRepository.Value;
        public IUserRepository User => _userRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
