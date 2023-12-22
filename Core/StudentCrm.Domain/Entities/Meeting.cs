using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Meeting : BaseEntity
{
    //public string Title { get; set; }
    public DateTime MeetingDate { get; set; }

}
