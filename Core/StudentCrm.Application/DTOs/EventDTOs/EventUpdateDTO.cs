using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.EventDTOs
{
    public class EventUpdateDTO
    {
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public int OrganizerId { get; set; }
    }
}
