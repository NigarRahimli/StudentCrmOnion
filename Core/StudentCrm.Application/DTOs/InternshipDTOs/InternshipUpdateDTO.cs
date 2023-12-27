using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.InternshipDTOs
{
    public class InternshipUpdateDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SupervisorID { get; set; }
     
    }
}
