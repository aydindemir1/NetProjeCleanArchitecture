using Application.Fuels.Repository;
using Application.Fuels.Service;
using Application.Fuels.Validator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Fuels.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Fuels.Configuration
{
    public static class FuelServiceExt
    {
        public static void AddFuelService(this IServiceCollection services)
        {
            services.AddScoped<IFuelService, FuelService>();
            //  services.AddScoped<IFuelRepository, FuelRepository>();
            services.AddScoped<IFuelRepository, FuelRepository>();

            services.AddValidatorsFromAssemblyContaining<FuelCreateRequestValidator>();
            services.AddScoped<NotFoundFilter>();
        }
    }
}
