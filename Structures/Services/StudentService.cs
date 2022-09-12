using Models.Models;
using Models.ViewModels;
using Repositories;
using Structures.Interfaces;

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

    public async Task<Student> GetDataById(int Id)
    {
        return await _studentRepository.GetDataById(Id);
    }

    public async Task<StudentViewModel> Update(StudentViewModel model, int Id)
    {
        return await _studentRepository.Update(model, Id);
    }

    public async Task<IEnumerable<Student>> GetAllData()
    {
        return await _studentRepository.GetAllData();
    }
}
