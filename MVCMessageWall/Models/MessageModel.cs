using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MVCMessageWall.Models
{
    public class MessageModel : PageModel
    {
        [Microsoft.Build.Framework.Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Really cool Message")]
        public string Message { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> FullNames { get; set; } = new List<string>();


        
    }
}
