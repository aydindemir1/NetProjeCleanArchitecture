﻿using Application.Brands.Repository;
using Domain.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Brands.Repository
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {
        }


        public async Task UpdateBrandName(string name, int id)
        {
            var brand = await GetById(id);
            brand!.Name = name;
            await Update(brand);
        }



    }
}
