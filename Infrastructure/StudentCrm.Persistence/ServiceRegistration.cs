using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentCrm.Application.Abstraction;
using StudentCrm.Application.Repositories;
using StudentCrm.Application.Repositories.Event;
using StudentCrm.Persistence.Contexts;
using StudentCrm.Persistence.Repositories;
using StudentCrm.Persistence.Repositories.Event;
using StudentCrm.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(option=>option.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<IEventReadRepository,EventReadRepository>();
            services.AddScoped<IEventWriteRepository, EventWriteRepository>();
            services.AddScoped<IEventService, EventService>();
         }
    }
}
