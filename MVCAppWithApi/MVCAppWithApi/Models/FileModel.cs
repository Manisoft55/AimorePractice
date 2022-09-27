using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MVCAppWithApi.Models
{
    public class FileModel
    {
        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public IFormFile PostedFile { get; set; }
    }
}
