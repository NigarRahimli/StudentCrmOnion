using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Task : BaseEntity

{
    public string TaskName { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }


}
