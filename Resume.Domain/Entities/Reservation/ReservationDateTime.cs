using Resume.Domain.Entities.Common;

namespace Resume.Domain.Entities.Reservation;

public class ReservationDateTime : BaseEntity<ulong>
{
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public bool IsReserved { get; set; }



    // Navigation properties
    public ulong ReservationDateId { get; set; }
    public virtual ReservationDate ReservationDate { get; set; }
    public virtual List<PersonSelectedReservation> peopleSelectedReservations { get; set; }

}
