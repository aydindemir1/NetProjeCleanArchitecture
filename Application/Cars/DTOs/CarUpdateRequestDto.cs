using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cars.DTOs
{
    public record CarUpdateRequestDto(string Plate, short MinFindexScore);
}
