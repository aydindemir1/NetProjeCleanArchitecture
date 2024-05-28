using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cars.DTOs
{
    public record CarDto(int Id, int ModelId, int Kilometer, short ModelYear, string Plate, short MinFindexScore);
}
