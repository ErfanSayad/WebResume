using Microsoft.AspNetCore.Mvc.Rendering;

namespace Resume.Presentation.Areas.AdminPanel.Views.Helpers;

public static class HtmlHelpers
{
    public static string IsActive(this IHtmlHelper htmlHelper,
                                     string controller,
                                     string action = null,
                                     string cssClass = "active")
    {
        var routeData = htmlHelper.ViewContext.RouteData;

        var routeAction = routeData.Values["action"]?.ToString();
        var routeController = routeData.Values["controller"]?.ToString();

        bool isActive = string.Equals(controller, routeController, System.StringComparison.OrdinalIgnoreCase) &&
                       (action == null || string.Equals(action, routeAction, System.StringComparison.OrdinalIgnoreCase));

        return isActive ? cssClass : string.Empty;
    }

    public static string IsMenuOpen(this IHtmlHelper htmlHelper,
                                    string controller,
                                    string cssClass = "menu-open")
    {
        var routeController = htmlHelper.ViewContext.RouteData.Values["controller"]?.ToString();

        bool isOpen = string.Equals(controller, routeController, System.StringComparison.OrdinalIgnoreCase);

        return isOpen ? cssClass : string.Empty;
    }

}
