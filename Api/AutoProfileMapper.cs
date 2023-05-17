using Api.Models;
using Applications.DTO;
using AutoMapper;

namespace Api
{
    public class AutoProfileMapper : AutoMapper.Profile
    {
        public AutoProfileMapper()
        {
            CreateMap<EmployeModels,EmployeDTO>();
            CreateMap<EmployeDTO, EmployeModels>();
        }
    }
}
