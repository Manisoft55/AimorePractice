using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MVCFilters.Filters
{
    public class RoleAccess : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
           var role = "Role checked";
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var role = "Role checked";
        }
    }
}
