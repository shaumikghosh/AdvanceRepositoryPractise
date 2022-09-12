using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels;
public class StudentViewModel
{
    public string ? StudentName { get; set; }
    public string ? StudentEmail { get; set; }
    public string ? StudentGender { get; set; }

    public string ? Message { get; set; }
    public string ? Type { get; set; }
}
