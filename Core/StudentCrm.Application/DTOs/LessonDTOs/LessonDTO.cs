using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.LessonDTOs
{
    public class LessonDTO
    {
        public string LessonName { get; set; }
        public List<int> Days { get; set; }
    }
}
