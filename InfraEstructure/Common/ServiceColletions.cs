using Microsoft.Extensions.DependencyInjection;
using System;
using Applications;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applications.Services;
using Dominio.Service;
using Dominio.Service.Repository;
using Dominio.Interfaces;
using EmployeRepository = InfraEstructure.Repository.EmployeRepository;
using EmployeRepos = Applications.Services.Repository.EmployeRepository;

namespace InfraEstructure.Common
{
    public static class ServiceColletions
    {
        public static void AddCommonLayer(this IServiceCollection services)
        {
            services.AddScoped<IEmployeService, EmployeRepos>();
            services.AddScoped<IEmployesService, ReposEmploye>();
            services.AddScoped<IEmployee,EmployeRepository>();

        }
    }
}
