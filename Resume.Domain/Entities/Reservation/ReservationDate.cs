using Resume.Domain.Entities.Common;

namespace Resume.Domain.Entities.Reservation;
public class ReservationDate : BaseEntity<ulong>
{
    public DateTime Date { get; set; }

    // Navigation property
    public virtual List<ReservationDateTime> ReservationDateTimes { get; set; } = new();



}
