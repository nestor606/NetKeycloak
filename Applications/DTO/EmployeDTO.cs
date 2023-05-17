using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.DTO
{
    public record EmployeDTO
    {
        public int ID { get; set; }
        public int IdentityCard { get; set; }
        public string? IdentityType { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Profession { get; set; }
        public string? NumberPhone { get; set; }
        public string? Adress { get; set; }
        public string? city { get; set; }
        public string? Status { get; set; }
        public string? Gender { get; set; }
        public DateTime? CreateDate { get; set; }
       
    }
}
