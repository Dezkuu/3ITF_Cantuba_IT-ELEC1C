using System.ComponentModel.DataAnnotations;

namespace CantubaITELEC1C.Models
{
    public enum IsRegular
    {
        Regular, Irregular, Conditional, Debarred
    }
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {

        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Status")]
        public IsRegular IsRegular { get; set; }

        [Required]
        public Course Course { get; set; }

        [Display(Name = "Date Enrolled")]
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}", 
            ErrorMessage = "You must follow format 000-000-0000")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Url]
        [Display(Name = "Personal Webpage")]
        public string URL { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}