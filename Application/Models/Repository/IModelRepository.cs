using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Repository
{
    public interface IModelRepository : IGenericRepository<Model>
    {
        Task UpdateModelName(string name, int id);
    }
}
