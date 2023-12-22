
using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class RegisterBlank : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
