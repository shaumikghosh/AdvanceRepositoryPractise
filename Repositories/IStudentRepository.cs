using Models.Models;
using Models.ViewModels;

namespace Repositories;
public interface IStudentRepository : IBaseRepository<StudentViewModel, Student>
{
    // if some specific operation need in future
}
