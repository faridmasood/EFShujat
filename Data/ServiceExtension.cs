using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public static class ServiceExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUnitOFWork, UnitOFWork>();
        }
    }
}