﻿
using Applications.DTO;
using Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public interface IEmployeService
    {
        Employee CreateEmployeeAndUser(EmployeDTO employe);
    }
}
