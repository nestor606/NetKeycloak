using Api.Models;
using Applications.DTO;
using Applications.Services;
using AutoMapper;
using Azure;
using Dominio.Entity;
using Dominio.Exception;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeController : Controller
    {
        private readonly IMapper _Mapper;
        private readonly IEmployeService _employeService;

        public EmployeController(IMapper mapper,IEmployeService employeService )
        {
            _Mapper = mapper;
            _employeService = employeService;
        }

        [HttpPost]
        public IActionResult CreateEmploye(EmployeModels employes)
        {
            var rps = new Dominio.Exception.Response<Employee>();
            try
            {
                rps.value = _employeService.CreateEmployeeAndUser(_Mapper.Map<EmployeDTO>(employes));
                rps.status = true;

            }
            catch (Exception ex)
            {

                rps.status = false;
                rps.menssage = ex.Message;
            }

            return Ok(new { rps.menssage, rps.status, rps.value });
        }
    }
}
