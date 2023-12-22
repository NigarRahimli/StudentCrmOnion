using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using StudentCrm.Application.AutoMapper;
using StudentCrm.Application.DTOs.EventDTOs;
using StudentCrm.Application.Validations.EventValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IValidator<EventCreateDTO>, RegisterEventValidation>();


        }
    }
}
