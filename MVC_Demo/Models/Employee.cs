using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models;   

    public class Employee
    {
 
        [Required(ErrorMessage = "name is required")]
        [Display(Name = "Employee full name")]
        [MaxLength(30, ErrorMessage = "name must have less than 30 characters")]
        public string Name { get; set; }


        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "email id is not in proper format")]
        public string Email { get; set; }


        [Required(ErrorMessage = "age is required")]
        [Range(18, 60, ErrorMessage = "age must be in between 18 -60")]

        public int Age { get; set; }


        [Required(ErrorMessage = "password is required")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "confirm password is required")]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "password and confirm password does not match")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
    }



