using Application.Cars.Repository;
using Application.Cars.Service;
using Application.Cars.Validator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Cars.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Cars.Configuration
{
    public static class CarServiceExt
    {
        public static void AddCarService(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<ICarRepository, CarRepository>();

            services.AddValidatorsFromAssemblyContaining<CarCreateRequestValidator>();
            services.AddScoped<NotFoundFilter>();
        }
    }
}
