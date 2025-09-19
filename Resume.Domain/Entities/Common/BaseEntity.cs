using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.Entities.Common;

public abstract class BaseEntity<T>
{
    [Key]
    public T Id { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public bool IsDelete { get; set; }
}
