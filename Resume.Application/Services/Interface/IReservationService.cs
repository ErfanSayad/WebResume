using Resume.Application.Convertors;
using Resume.Domain.Entities.Reservation;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Interface;

public interface IReservationService
{
    Task<List<ReservationDate>> GetListOfReservation(CancellationToken cancellationToken);


    Task<bool> CreateReservation(string date, CancellationToken cancellationToken);

    Task<ReservationDate> GetReservationDate(ulong reservationDateId,
        CancellationToken cancellationToken);

    Task<bool> EditeReservationDate(ulong reservationDateId,
        string date, CancellationToken cancellationToken);


    Task<bool> DeleteReservationDate(ulong reservationDateId,
    string date, CancellationToken cancellationToken);
}
