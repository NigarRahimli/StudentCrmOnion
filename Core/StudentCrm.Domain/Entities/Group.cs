using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Group : BaseEntity
{
    public string GroupNumber { get; set; }
    public bool IsActive { get; set; }  
}
