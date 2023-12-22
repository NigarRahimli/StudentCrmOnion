using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Student : BaseEntity
{
    public string  FirstName{ get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
    public string Email { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }

    public int AttendanceId { get; set; }
    public Attendance Attendance { get; set; }

}
