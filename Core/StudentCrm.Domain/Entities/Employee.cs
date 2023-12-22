using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Employee:BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime StartWork { get; set; }
    public DateTime Present { get; set; }

}
