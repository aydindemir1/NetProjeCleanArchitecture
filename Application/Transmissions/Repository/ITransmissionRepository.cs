using Domain.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Transmissions.Repository
{
    public interface ITransmissionRepository : IGenericRepository<Transmission>
    {
        Task UpdateTransmissionName(string name, int id);
    }
}
