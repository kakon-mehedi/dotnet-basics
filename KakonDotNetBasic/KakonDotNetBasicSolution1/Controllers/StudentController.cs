using KakonDotNetBasicSolution1.Models;
using Microsoft.AspNetCore.Mvc;

namespace KakonDotNetBasicSolution1.Controllers;

public class StudentController : Controller
{
    public string Index()
    {
        return "Students";
    }

    [HttpPost]
    public IActionResult Index([FromBody] Student student)
    {
        var firstName = student.FullName;
        var roll = student.Roll;

        return Ok(student);
    }
}