using System.ComponentModel.DataAnnotations;

namespace honproject.Models
{
    public class AdminPasswordModels
    {
        public string Id { get; set; }

        public string FullName { get; set; }


        [Required]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }
    }
}