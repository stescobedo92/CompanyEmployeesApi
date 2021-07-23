using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace CompanyEmployees.Entities.DTO
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FullAdress { get; set; }
    }
}
