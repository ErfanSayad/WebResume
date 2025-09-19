using Resume.Domain.Entities.Common;

namespace Resume.Domain.Entities.Reservation;

public class PersonSelectedReservation : BaseEntity<ulong>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }

    // Navigation properties
    public ulong ReservationDateTimeId { get; set; }
    public virtual ReservationDateTime ReservationDateTime { get; set; }


}
