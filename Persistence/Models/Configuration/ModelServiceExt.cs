using Application.Models.Repository;
using Application.Models.Service;
using Application.Models.Validator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models.Configuration
{
    public static class ModelServiceExt
    {
        public static void AddModelService(this IServiceCollection services)
        {
            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<IModelRepository, ModelRepository>();

            services.AddValidatorsFromAssemblyContaining<ModelCreateRequestValidator>();
            services.AddScoped<NotFoundFilter>();
        }
    }
}
