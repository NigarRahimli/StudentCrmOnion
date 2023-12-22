using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Internship : BaseEntity
{
    //public string Title { get; set; }
    //public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int SupervisorID { get; set; }
    public User User { get; set; }
}
