using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Filters
{
    public class CustomAuthorizationFilterAttribute : Attribute, IAuthorizationFilter
    {
        private string _name;

        public CustomAuthorizationFilterAttribute(string name)
        {
            _name = name;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string currentUserRole = Convert.ToString(context.HttpContext.Request.Headers["UserRole"]);

            if (!string.IsNullOrEmpty(currentUserRole))
            {
                if (currentUserRole != "Admin")
                {
                    //context.Result = new RedirectToRouteResult(
                    //    new RouteValueDictionary(
                    //        new { action = "Error", controller = "Error" }
                    //        )
                    //    );

                    context.Result = new ForbidResult();

                }
            }
        }
    }
}
