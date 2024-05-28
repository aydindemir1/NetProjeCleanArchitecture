using Application.Fuels.Repository;
using Domain.Fuels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Fuels.Repository
{
    public class FuelRepository : GenericRepository<Fuel>, IFuelRepository
    {
        public FuelRepository(AppDbContext context) : base(context)
        {
        }


        public async Task UpdateFuelName(string name, int id)
        {
            var Fuel = await GetById(id);
            Fuel!.Name = name;
            await Update(Fuel);
        }
    }
}
