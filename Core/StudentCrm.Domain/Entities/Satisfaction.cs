
using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Satisfaction : BaseEntity
{
    public int StudentId { get; set; }
    Student Student { get; set; }
    public int Rating { get; set; }
    public string Message { get; set; }
}
