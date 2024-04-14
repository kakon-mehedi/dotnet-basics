namespace KakonDotNetBasicSolution1.Model;

public class Student
{
    public string FullName { get; set; }
    
    public string StudentId { get; set; }

    public int Age { get; set; }

    public Department Department { get; set; }

}

public class StudentDatabase
{
    public List<Student> GetStudents()
    {
        var students = new List<Student>
        {
            new Student
            {
                FullName = "Kakon",
                Age = 28,
                StudentId = "101",
                Department = new Department
                {
                    ChairmanName = "Somlal",
                    DepartmentName = "CSE",
                    DepartmentId = "CSE123",
                    TotalStuents = 380
                }
            },
            
            new Student
            {
                FullName = "Mehedi",
                Age = 30,
                StudentId = "102",
                Department = new Department
                {
                    ChairmanName = "Iqbal Aziz",
                    DepartmentName = "ICE",
                    DepartmentId = "ICE123",
                    TotalStuents = 340
                }
            }
        };

        return students;

    }
}