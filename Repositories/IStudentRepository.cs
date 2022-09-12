using Models.Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories;
public interface IStudentRepository : IBaseRepository<StudentViewModel, Student>
{
    // if some specific operation need in future
}
