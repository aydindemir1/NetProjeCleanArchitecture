using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.DTOs
{
    public record ModelCreateRequestDto(string Name, int BrandId, int FuelId, int TransmissionId, decimal DailyPrice, string ImageUrl);
}
