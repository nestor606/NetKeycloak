using Dominio.Entity;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Service.Repository
{
    public class ReposEmploye : IEmployesService
    {
        public readonly IEmployee _employes;

        public ReposEmploye(IEmployee employee)
        {
            _employes = employee;
            
        }
        public Employee CreateEmploye(Employee employe)
        {
            _employes.CreateEmploye(employe);
            return employe;
        }
    }
}
