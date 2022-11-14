using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AssignmentPart2People.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name = "Person")]
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? CityName { get; set; }
        public int PhoneNumber { get; set; }
    }
}
