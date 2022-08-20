using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MVCFilters.Filters
{
    public class CustomAuthorizationFilter : Attribute, IAuthorizationFilter 
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var username = Convert.ToString(context.HttpContext.Request.Headers["user-name"]);
            if(username != "Rajesh")
            {
                //throw new Exception("Invalid user name");
            }
        }
    }
}
