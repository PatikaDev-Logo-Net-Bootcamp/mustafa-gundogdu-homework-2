using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
namespace homework_2.Middlewares
{
    public class AddDefaultKeyHeaderParameter: IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            //operation.Parameters.Add(new OpenApiParameter
            //{
            //     Name = "app-version",
            //     In = ParameterLocation.Header,
            //     Schema =
            //     {
            //         Type = "string",
            //     }
            //});
            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "AppVersion",
                In = ParameterLocation.Header,
                Description = " Last current version is 4.0.0 dont try before versions",
                Required = true,
            });

        }
    }
}
