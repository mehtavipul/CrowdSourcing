using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SE.Catalog.Repository
{
    public static class DbRepositoryService
    {        
        public static void AddRepository(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<CatalogContext>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("CatalogContext")));            
        }
    }
}
