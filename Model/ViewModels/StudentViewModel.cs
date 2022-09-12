using System.ComponentModel.DataAnnotations;

namespace Models.ViewModels;
public class StudentViewModel
{
    [Required(ErrorMessage = "Student name is required")]
    public string ? StudentName { get; set; }

    [Required(ErrorMessage = "Student email is required")]
    public string ? StudentEmail { get; set; }

    public string ? Message { get; set; }
    public string ? Type { get; set; }
}
