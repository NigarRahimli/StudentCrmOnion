using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Attendance:BaseEntity
{
    public int UserID { get; set; }
    public DateTime LessonDate { get; set;}
    public bool IsPresent { get; set; }
}
