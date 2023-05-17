using Applications.DTO;
using AutoMapper;
using Dominio.Entity;
using Dominio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services.Repository
{
    public class EmployeRepository : IEmployeService
    {
        private readonly IMapper _mapper;
        private readonly IEmployesService _IEmployeService;

        public EmployeRepository(IMapper mapper, IEmployesService IEmploye)
        {
            _mapper = mapper;
            _IEmployeService = IEmploye;
            
        }
        public Employee CreateEmployeeAndUser(EmployeDTO employe)
        {
            Employee _employe = _mapper.Map<Employee>(employe);
            var request = _IEmployeService.CreateEmploye(_employe);
            return request;
        }
    }
}
