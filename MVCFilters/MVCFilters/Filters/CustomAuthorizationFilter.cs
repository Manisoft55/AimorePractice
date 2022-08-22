using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;

namespace MVCFilters.Filters
{
    public class CustomAuthorizationFilter : Attribute, IAuthorizationFilter 
    {
        private ITempDataDictionary _tempDataDictionaryFactory;
        
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            ITempDataDictionaryFactory factory = context.HttpContext.RequestServices.GetService(typeof(ITempDataDictionaryFactory)) as ITempDataDictionaryFactory;
            ITempDataDictionary tempData = factory.GetTempData(context.HttpContext);
            var username = Convert.ToString(tempData["username"]);
            if (username != "Rajesh")
            {
                
            }
        }
    }
}
