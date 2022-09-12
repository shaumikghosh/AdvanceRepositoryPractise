using Models.Models;
using Models.ViewModels;
using Repositories;
using Structures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Services;
public class StudentService : BaseService, IStudent

{
    protected readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentrepository)
    {
        _studentRepository = studentrepository;
    }

    public async Task<StudentViewModel> Create(StudentViewModel model)
    {
        return await _studentRepository.Create(model);
    }

    public async Task DeleteById(int Id)
    {
        await _studentRepository.DeleteById(Id);
    }

    public Task<IEnumerable<StudentViewModel>> GetAllData()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        return await _studentRepository.GetAllStudents();
    }

    public Task<StudentViewModel> GetDataById(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Student> GetStudentDetailsById(int Id)
    {
        return await _studentRepository.GetStudentDetailsById(Id);
    }

    public async Task<StudentViewModel> Update(StudentViewModel model, int Id)
    {
        return await _studentRepository.Update(model, Id);
    }
}
