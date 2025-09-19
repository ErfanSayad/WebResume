using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Resume.Domain.Entities.Reservation;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.infrastructure.Repository;

public class ReservationRepository : IReservationRepository
{
    private readonly ResumeDbContext _context;

    public ReservationRepository(ResumeDbContext context)
    {
        _context = context;
    }

    public async Task<List<ReservationDate>> GetListOfReservation(CancellationToken cancellationToken)
        => await _context.reservationDates
                        .Where(p => !p.IsDelete)
                        .OrderByDescending(p => p.CreateDate)
                        .ToListAsync();

    public async Task<ReservationDate> GetReservationDate(ulong reservationDateId, CancellationToken cancellationToken)
        => await _context.reservationDates.FindAsync(reservationDateId, cancellationToken);

    public async Task AddReservationDate(ReservationDate reservationDate, CancellationToken cancellationToken)
        => await _context.reservationDates.AddAsync(reservationDate);

    public void UpdateReservation(ReservationDate reservationDate)
        => _context.reservationDates.Update(reservationDate);

    public async Task SaveChangeAsync(CancellationToken cancellationToken)
        => await _context.SaveChangesAsync();


}
