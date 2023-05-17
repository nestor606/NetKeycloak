using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exception
{
    public class Response<t>
    {
        public bool status { get; set; }
        public t value { get; set; }
        public string? menssage { get; set; }
    }
}
