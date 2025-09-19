namespace Resume.Presentation.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

public static class HtmlHelpers
{
    public static string IsActive(this IHtmlHelper htmlHelper, string controller, string action)
    {
        var routeData = htmlHelper.ViewContext.RouteData.Values;

        var currentController = routeData["controller"]?.ToString();
        var currentAction = routeData["action"]?.ToString();

        return (string.Equals(controller, currentController, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(action, currentAction, StringComparison.OrdinalIgnoreCase))
            ? "active"
            : "";
    }
}
