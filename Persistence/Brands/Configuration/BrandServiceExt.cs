using Application.Brands.Repository;
using Application.Brands.Service;
using Application.Brands.Validator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Brands.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Brands.Configuration
{
    public static class BrandServiceExt
    {
        public static void AddBrandService(this IServiceCollection services)
        {
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddValidatorsFromAssemblyContaining<BrandCreateRequestValidator>();
            services.AddScoped<NotFoundFilter>();
        }
    }
}
