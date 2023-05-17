using Applications.DTO;
using Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class AutoMappingProfile : AutoMapper.Profile
    {

        public AutoMappingProfile()
        {
            CreateMap<Employee, EmployeDTO>();
            CreateMap<EmployeDTO, Employee>();
        }
    }
}
