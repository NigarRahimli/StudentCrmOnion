using StudentCrm.Domain.Entities.Common;

namespace StudentCrm.Domain.Entities;

public class Expense:BaseEntity
{
    public decimal Price { get; set; }
    public string Note { get; set; }
    public decimal Quantity { get; set; }
    public ExpenseType ExpenseType { get; set; }
    public int ExpenseTypeId { get; set; }
}
