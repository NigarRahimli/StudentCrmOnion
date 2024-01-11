
using StudentCrm.Application.DTOs.AttendanceDTOs;
using StudentCrm.Application.Responses;
using StudentCrm.Application.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Abstraction
{
    public interface IAttendanceService
    {
        IResult CreateAttendance(UserAttendanceCreateDTO eventCreateDTO);
        List<UserAttendanceDTO> GetEvents();
    }
}
