using System.ComponentModel.DataAnnotations;

namespace Models.Models;
public class Student
{
    [Key]
    public int Id { get; set; }
    public string ? StudentName { get; set; }
    public string ? StudentEmail { get; set; }
}
