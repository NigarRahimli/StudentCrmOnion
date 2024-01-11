using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.UserPositionDTOs
{
    public class UserPositionUpdateDTO
    {
        public int UserId { get; set; }
        public int PositionId { get; set; }
    }
}
