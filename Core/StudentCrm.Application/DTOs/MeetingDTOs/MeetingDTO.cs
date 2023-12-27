using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.MeetingDTOs
{
    public class MeetingDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime MeetingDate { get; set; }
    }
}
