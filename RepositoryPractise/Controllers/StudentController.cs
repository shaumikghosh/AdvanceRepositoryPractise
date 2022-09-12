using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.ViewModels;
using RepositoryPractise.Models;
using Structures.Interfaces;
using System.Diagnostics;

namespace RepositoryPractise.Controllers;
[Route("api")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;
    private readonly IStudent _student;

    public StudentController(ILogger<StudentController> logger, IStudent student)
    {
        _logger = logger;
        _student = student;
    }

    [HttpGet("students")]
    public async Task<IActionResult> GetAllStudents()
    {
        var result = await _student.GetAllData();
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpPost("create-student")]
    public async Task<IActionResult> CreateStudent(StudentViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _student.Create(model);
            return StatusCode(StatusCodes.Status201Created, result);
        }
        return Ok(ModelState.Select(x => x.Value!.Errors)
                           .Where(y => y.Count > 0)
                           .ToList());
    }

    [HttpGet("student/{id:int}")]
    public async Task<IActionResult> GetStudentDetailsById(int Id)
    {
        var result = await _student.GetDataById(Id);
        return StatusCode(StatusCodes.Status200OK, result);
    }

    [HttpPut("update/{id:int}")]
    public async Task<IActionResult> UpdateStudent(StudentViewModel model, int Id)
    {
        if (ModelState.IsValid)
        {
            var result = await _student.Update(model, Id);
            return StatusCode(StatusCodes.Status201Created, result);
        }
        return StatusCode(StatusCodes.Status200OK, new { Message = "Something went wrong" });
    }

    [HttpDelete("delete/{id:int}")]
    public async Task<IActionResult> DeleteStudent(int Id)
    {
        await _student.DeleteById(Id);
        var result = new { Message = "Studebt has been removed from database!"};
        return StatusCode(StatusCodes.Status202Accepted, result);
    }
}
