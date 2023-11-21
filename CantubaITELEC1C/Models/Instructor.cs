using System.ComponentModel.DataAnnotations;

namespace CantubaITELEC1C.Models
{
    public enum IsTenured
    {
        Permanent, Probationary
    }
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {

        [Required]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Status")]
        public IsTenured IsTenured { get; set; }

        [Required]
        public Rank Rank { get; set; }

        [Display(Name = "Date Hired")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

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