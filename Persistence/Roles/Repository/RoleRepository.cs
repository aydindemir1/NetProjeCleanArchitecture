﻿using Application.Roles.Repository;
using Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Roles.Repository
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(AppDbContext context) : base(context)
        {
        }


        public async Task UpdateRoleName(string name, int id)
        {
            var Role = await GetById(id);
            Role!.Name = name;
            await Update(Role);
        }
    }
}
