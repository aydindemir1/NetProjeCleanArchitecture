using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Transmissions.DTOs
{
    public class TransmissionDto
    {
        public TransmissionDto()
        {
        }

        public TransmissionDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
