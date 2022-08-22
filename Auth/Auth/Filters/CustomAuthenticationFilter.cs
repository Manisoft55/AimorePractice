using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Auth.Filters
{
    public class CustomAuthenticationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            
            if (context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any()) return;
            var user = context.HttpContext.User;

            var role = user.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
            if(role == "Admin")
            {
                if(context.ActionDescriptor.RouteValues["action"] == "Index" && context.ActionDescriptor.RouteValues["controller"] == "Home")
                {
                    return;
                }
                else
                {
                    context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                         { "controller", "Account" },
                         { "action", "Login" }
                    });
                }
            }
            else if (role == "User")
            {
                if (context.ActionDescriptor.RouteValues["action"] == "Privacy" && context.ActionDescriptor.RouteValues["controller"] == "Home")
                {
                    return;
                }
                else
                {
                    context.Result = new UnauthorizedResult();
                }
            }
            else
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                         { "controller", "Account" },
                         { "action", "Login" }
                    });
            }
        }
    }
}
