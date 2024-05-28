using Application.Models.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models.Repository
{
    public class ModelRepository : GenericRepository<Model>, IModelRepository
    {
        public ModelRepository(AppDbContext context) : base(context)
        {
        }


        public async Task UpdateModelName(string name, int id)
        {
            var Model = await GetById(id);
            Model!.Name = name;
            await Update(Model);
        }
    }
}
