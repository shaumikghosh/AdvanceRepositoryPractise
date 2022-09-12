using Models.Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Interfaces;
public interface IStudent : IBase<StudentViewModel>
{
    Task<IEnumerable<Student>> GetAllStudents();
    Task<Student> GetStudentDetailsById(int Id);
}
