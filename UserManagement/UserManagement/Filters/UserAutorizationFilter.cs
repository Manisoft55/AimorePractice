using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace UserManagement.Filters
{
    public class UserAutorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            var role = user.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
            if (role == "Admin")
            {
                if (context.ActionDescriptor.RouteValues["action"] == "Index" && context.ActionDescriptor.RouteValues["controller"] == "Home")
                {
                    return;
                }
                if (context.ActionDescriptor.RouteValues["action"] == "Index" && context.ActionDescriptor.RouteValues["controller"] == "UserInfo")
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
                if (context.ActionDescriptor.RouteValues["action"] == "Index" && context.ActionDescriptor.RouteValues["controller"] == "UserInfo")
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

