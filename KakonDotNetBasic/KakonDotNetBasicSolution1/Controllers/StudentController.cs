using KakonDotNetBasicSolution1.Model;
using Microsoft.AspNetCore.Mvc;

namespace KakonDotNetBasicSolution1.Controllers;

public class StudentController : Controller
{
    [HttpGet]
    public List<Student> GetStudents()
    {
        var studentDatabase = new StudentDatabase();
        var students = studentDatabase.GetStudents();

        return students;
    }

    [HttpGet]
    public ActionResult<Student> GetStudentById(string id)
    {
        var students = GetStudents();
        var student = students.Find(student => student.StudentId == id);
        return student != null ? Ok(student) : NotFound();
    }

    [HttpPost]
    public ActionResult<List<Student>> AddStudent([FromBody] Student student)
    {
        var students = GetStudents();
        students.Add(student);
       
        return Ok(students);
    }
    
}