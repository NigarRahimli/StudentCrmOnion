using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class User : BaseEntity
{
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool Password { get; set; }
    public bool PasswordRepeat { get; set; }

}
