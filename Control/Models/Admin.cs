using System.ComponentModel.DataAnnotations;
using Control.Interfaces;

namespace Control.Models
{
    public class Admin : IAdmin
    {
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Admin {0} is required")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Name Should be minimum 10 characters and a maximum of 200 characters")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "UserName Should be minimum 10 characters and a maximum of 100 characters")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "This must be an email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
