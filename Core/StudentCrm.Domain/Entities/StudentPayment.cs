
using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class StudentPayment : BaseEntity

{
    public int StudentId { get; set; }
    public Student Student { get; set;}
    public DateTime Deadline { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }  //look
}
