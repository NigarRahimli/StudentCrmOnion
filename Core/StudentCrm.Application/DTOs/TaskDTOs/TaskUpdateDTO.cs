using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.TaskDTOs
{
    public class TaskUpdateDTO
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
