using System.ComponentModel.DataAnnotations;

namespace Technical_Task.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "name is required")]
        [StringLength(20, MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "FullName is required")]
        public string UserFullName { get; set; }

        public bool IsActive { get; set; } = true;

        [Required(ErrorMessage = "the dateofbirth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
