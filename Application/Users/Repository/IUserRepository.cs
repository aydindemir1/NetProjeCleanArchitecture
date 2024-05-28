using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task UpdateUserName(string name, int id);
    }
}
