using System;
using AngularAspNetCoreTemplate.Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AngularAspNetCoreTemplate.Domain.Models
{
    public static class InitializeData
    {
        public static void Initialize(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            ILogger logger = loggerFactory.CreateLogger("InitializeData");
            context.Database.Migrate();

            // add any code here to initialize database tables with data
        }
    }
}