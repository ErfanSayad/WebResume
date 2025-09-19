using Resume.Application.Convertors;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Reservation;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation;

public class ReservationService : IReservationService
{
    private readonly IReservationRepository _reservationRepository;
    public ReservationService(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    public async Task<List<ReservationDate>> GetListOfReservation(CancellationToken cancellationToken)
              => await _reservationRepository.GetListOfReservation(cancellationToken);

    public async Task<bool> CreateReservation(string date, CancellationToken cancellationToken)
    {
        await _reservationRepository.AddReservationDate(new ReservationDate()
        {
            Date = date.ToMiladiDateTime()
        } , cancellationToken);
        await _reservationRepository.SaveChangeAsync(cancellationToken);

        return true;
    }

    public async Task<ReservationDate> GetReservationDate(ulong reservationDateId,
        CancellationToken cancellationToken)
    => await _reservationRepository.GetReservationDate(reservationDateId, cancellationToken);

    public async Task<bool> EditeReservationDate(ulong reservationDateId,
        string date, CancellationToken cancellationToken)
    {
        // Find original recoed
        var originalRecord = await _reservationRepository.GetReservationDate(reservationDateId, cancellationToken);
        if (originalRecord == null)
            return false;

        originalRecord.Date = date.ToMiladiDateTime();

        _reservationRepository.UpdateReservation(originalRecord);
        await _reservationRepository.SaveChangeAsync(cancellationToken);

        return true;
    }


    public async Task<bool> DeleteReservationDate(ulong reservationDateId,
    string date, CancellationToken cancellationToken)
    {
        // Find original recoed
        var originalRecord = await _reservationRepository.GetReservationDate(reservationDateId, cancellationToken);
        if (originalRecord == null)
            return false;

        originalRecord.IsDelete = true;

        _reservationRepository.UpdateReservation(originalRecord);
        await _reservationRepository.SaveChangeAsync(cancellationToken);

        return true;
    }
}
