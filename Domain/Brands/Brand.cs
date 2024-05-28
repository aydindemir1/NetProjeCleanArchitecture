﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Brands
{
    public class Brand : BaseEntity<int>
    {
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }

        public Brand()
        {
            Models = new HashSet<Model>();
        }

        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}
