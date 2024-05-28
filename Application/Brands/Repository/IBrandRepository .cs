using Domain.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Brands.Repository
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {
        Task UpdateBrandName(string name, int id);
    }
}
