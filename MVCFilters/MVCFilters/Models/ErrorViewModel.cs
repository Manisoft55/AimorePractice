using System;
using System.ComponentModel.DataAnnotations;

namespace MVCFilters.Models
{
    public class ErrorViewModel
    {
        
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
