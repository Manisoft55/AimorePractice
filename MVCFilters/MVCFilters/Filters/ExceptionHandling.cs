using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace MVCFilters.Filters
{
    public class ExceptionHandling : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exep = context.Exception;
        }
    }
}
