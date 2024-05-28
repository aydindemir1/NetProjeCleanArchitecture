using Application.Transmissions.Repository;
using Application.Transmissions.Service;
using Application.Transmissions.Validator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Transmissions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Transmissions.Configuration
{
    public static class TransmissionServiceExt
    {
        public static void AddTransmissionService(this IServiceCollection services)
        {
            services.AddScoped<ITransmissionService, TransmissionService>();
            services.AddScoped<ITransmissionRepository, TransmissionRepository>();

            services.AddValidatorsFromAssemblyContaining<TransmissionCreateRequestValidator>();
            services.AddScoped<NotFoundFilter>();
        }
    }
}
