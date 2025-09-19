using Microsoft.AspNetCore.Mvc;
namespace Resume.Presentation.Areas.AdminPanel.Controllers;

public class AdminBaseController : Controller
{
    protected string SuccessMessage = "SuccessMessage";
    protected string WarningMessage = "WarningMessage";
    protected string InfoMessage = "InfoMessage";
    protected string ErrorMessage = "ErrorMessage";

}
