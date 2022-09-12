using Models.Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories;
public interface IStudentRepository : IBaseRepository<StudentViewModel>
{
    Task<IEnumerable<Student>> GetAllStudents();
    Task<Student> GetStudentDetailsById(int Id);
}
