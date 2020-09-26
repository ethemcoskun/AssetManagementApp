using System.ComponentModel.DataAnnotations;

namespace AssetApp.API.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string username { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Please enter a password of 5 to 10 characters!")]
        public string password { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }


        [EmailAddress]
        public string email { get; set; }

        public string title { get; set; }

    }
}