using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBase.Domain.Entities;
using WarehouseBase.Domain.Interfaces;
using WarehouseBase.Infrastructure.Persistence;
using WarehouseBase.Infrastructure.Repositories;

namespace WarehouseBase.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WarehouseBaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BaseRecord")));

            services.AddScoped<IWarehouseBaseRepository, WarehouseBaseRepository>();
        }
    }
}
