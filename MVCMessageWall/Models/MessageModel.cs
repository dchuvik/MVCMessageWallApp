using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MVCMessageWall.Models
{
    public class MessageModel
    {
        [Microsoft.Build.Framework.Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Really cool Message")]
        public string Message { get; set; }
    }
}
