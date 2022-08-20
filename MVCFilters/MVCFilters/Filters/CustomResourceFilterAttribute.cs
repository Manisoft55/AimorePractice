using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MVCFilters.Filters
{
    public class CustomResourceFilterAttribute : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            var role = "Roles retrieved";
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var role = "Roles retrieved";
        }
    }
}
