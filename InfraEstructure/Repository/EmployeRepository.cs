using Dominio.Entity;
using Dominio.Interfaces;
using InfraEstructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstructure.Repository
{
    internal class EmployeRepository : IEmployee
    {
        private readonly ApplicationsDbContext _DbContext;
        public EmployeRepository(ApplicationsDbContext Context)
        {
            _DbContext = Context;
        }
        public void CreateEmploye(Employee employe)
        {
            _DbContext.Employee.Add(employe);
            employe.CreateDate = DateTime.Now;
            _DbContext.SaveChanges();
        }
    }
}
