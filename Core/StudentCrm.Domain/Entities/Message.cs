using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Message : BaseEntity
{
    public int SenderId { get; set; }
    public int RecieverId { get; set; }
    public User User { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
}
