using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Implementation;
namespace Resume.Presentation.Areas.AdminPanel.Controllers;

public class ReservationController : AdminBaseController
{
    private readonly ReservationService _reservationService;
    public ReservationController(ReservationService reservationService)
    {
        _reservationService = reservationService;
    }


    [HttpGet]
    public async Task<IActionResult> ListOfReservationDate(CancellationToken cancellationToken = default)  
        => View(await _reservationService.GetListOfReservation(cancellationToken));



}
