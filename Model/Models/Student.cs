using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models;
public class Student
{
    [Key]
    public int Id { get; set; }
    public string ? StudentName { get; set; }
    public string ? StudentEmail { get; set; }
}
