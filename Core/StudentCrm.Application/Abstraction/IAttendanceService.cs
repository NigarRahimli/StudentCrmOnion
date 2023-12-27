
using StudentCrm.Application.DTOs.AttendanceDTOs;
using StudentCrm.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Abstraction
{
    public interface IAttendanceService
    {
        public Task<Result> CreateAttendance(UserAttendanceCreateDTO eventCreateDTO);
        List<UserAttendanceDTO> GetEvents();
    }
}
