
using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Lesson : BaseEntity
{
    public string LessonName { get; set; }
    public string Description { get; set; }
    public List<int> Days { get; set; }



}
