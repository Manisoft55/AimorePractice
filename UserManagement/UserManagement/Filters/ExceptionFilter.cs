using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace UserManagement.Filters
{
    public class ExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var message = context.Exception.Message;
        }
    }
}
