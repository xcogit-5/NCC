using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class ModelStudent
    {
        public int? Roll { get; set; }
        public string? Name { get; set; }
        /*//[Range (1, 10)]
        public int Roll { get; set; }

        [Required(ErrorMessage ="Enter Your Name")]
        [Display(Name ="Full Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Enter Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name="Confirm Password")]
        [DataType(DataType.Password)]
        
        [Compare("Password",ErrorMessage ="Password Does Not Match")]
        public string? ConfirmPassword { get; set; }*/
    }
}
