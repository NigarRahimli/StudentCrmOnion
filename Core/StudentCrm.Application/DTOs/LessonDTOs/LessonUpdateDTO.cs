using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.LessonDTOs
{
    public class LessonUpdateDTO
    {
        public string LessonName { get; set; }
        public string Description { get; set; }
        public List<int> Days { get; set; }
    }
}
