using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Conracts
{
    public interface IRepositoryManager
    {
        IFilmRepository Film { get; }
        IUserRepository User { get; }

        void Save();
    }
}
