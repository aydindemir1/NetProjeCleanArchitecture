using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Fuels
{

    public class Fuel : BaseEntity<int>
    {
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }

        public Fuel()
        {
            Models = new HashSet<Model>();
        }

        public Fuel(int id, string name)
            : this()
        {
            Id = id;
            Name = name;
        }
    }
}
