using Application.Users.Repository;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Users.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }


        public async Task UpdateUserName(string name, int id)
        {
            var User = await GetById(id);
            User!.Name = name;
            await Update(User);
        }
    }

}
