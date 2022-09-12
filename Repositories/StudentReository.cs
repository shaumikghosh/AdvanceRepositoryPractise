using Enums;
using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories;
public class StudentReository : BaseRpository, IStudentRepository
{
    private readonly DataContext _dataContext;

    public StudentReository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<StudentViewModel> Create(StudentViewModel model)
    {
        var student = new Student
        {
            StudentName = model.StudentName,
            StudentEmail = model.StudentEmail,
        };
        await _dataContext.Students!.AddAsync(student);
        await _dataContext.SaveChangesAsync();
        return new StudentViewModel
        {
            Message = "New student added successfully!",
            Type = responseType.Success.ToString()
        };
    }

    public async Task DeleteById(int Id)
    {
        var student = await _dataContext.Students!.FindAsync(Id);
        if(student != null)
            _dataContext.Students.Remove(student);
    }

    public Task<IEnumerable<StudentViewModel>> GetAllData()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        return await _dataContext.Students!.ToListAsync();
    }

    public Task<StudentViewModel> GetDataById(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Student> GetStudentDetailsById(int Id)
    {
        var student = await _dataContext.Students!.FindAsync(Id);
        return new Student
        {
            Id = student!.Id,
            StudentName = student!.StudentName,
            StudentEmail=student!.StudentEmail,
            
        };
    }

    public async Task<StudentViewModel> Update(StudentViewModel model, int Id)
    {
        var student = await _dataContext.Students!.FindAsync(Id);
        student!.StudentName = model.StudentName;
        student.StudentEmail = model.StudentEmail;
        _dataContext.Students.Update(student);
        _dataContext.SaveChangesAsync().Wait();

        return new StudentViewModel
        {
            Message = "Student data has been updated successfully!",
            Type = responseType.Success.ToString()
        };
    }
}
