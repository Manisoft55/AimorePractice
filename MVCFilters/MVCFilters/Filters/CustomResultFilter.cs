using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MVCFilters.Filters
{
    public class CustomResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            var result = "Result returned";
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            var result = "Result returned";
        }
    }
}
