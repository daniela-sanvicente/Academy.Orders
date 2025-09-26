using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Orders.Presentation.Modules
{
    public class ModulesConfiguration
    {
        public static void Configure(WebApplication app)
        {
            app.AddOrderModules();
        }
    }
}
