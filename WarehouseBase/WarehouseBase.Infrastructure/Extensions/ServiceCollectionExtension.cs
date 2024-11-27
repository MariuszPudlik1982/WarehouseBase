using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBase.Domain.Entities;
using WarehouseBase.Infrastructure.Persistence;

namespace WarehouseBase.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WarehouseBaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BaseRecord")));
        }
    }
}
