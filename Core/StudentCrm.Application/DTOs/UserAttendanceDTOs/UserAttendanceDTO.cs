using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.AttendanceDTOs
{
    public class UserAttendanceDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LessonDate { get; set; }
        public bool IsPresent { get; set; }
    }
}
