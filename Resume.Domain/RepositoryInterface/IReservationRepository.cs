using Resume.Domain.Entities.Reservation;
namespace Resume.Domain.RepositoryInterface;

public interface IReservationRepository
{
    Task<List<ReservationDate>> GetListOfReservation(CancellationToken cancellationToken);
    Task<ReservationDate> GetReservationDate(ulong reservationDateId, CancellationToken cancellationToken);
    Task AddReservationDate(ReservationDate reservationDate, CancellationToken cancellationToken);
    void UpdateReservation(ReservationDate reservationDate);
    Task SaveChangeAsync(CancellationToken cancellationToken);

}
