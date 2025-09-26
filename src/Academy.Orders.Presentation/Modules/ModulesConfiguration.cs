using Microsoft.AspNetCore.Builder;

namespace Academy.Orders.Presentation.Modules;
public class ModulesConfiguration
{
    public static void Configure(WebApplication app)
    {
        app.AddOrderModules();
    }
}