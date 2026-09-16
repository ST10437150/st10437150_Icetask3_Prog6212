using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // 1. List of at least 6 students, with a mix of marks above and below 75
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Adelia", Marks = 82 },
            new Student { Id = 2, Name = "Neuza", Marks = 68 },
            new Student { Id = 3, Name = "Jacira", Marks = 90 },
            new Student { Id = 4, Name = "Lwazi", Marks = 55 },
            new Student { Id = 5, Name = "Wilson", Marks = 77 },
            new Student { Id = 6, Name = "Smanga", Marks = 60 }
        };

        // 2. Use LINQ to filter students who scored more than 75
        // 3. Use an anonymous type to project only Name and a new Result property
        var passedStudents = students
            .Where(s => s.Marks > 75)
            .Select(s => new { s.Name, Result = "Pass" });

        // 4. Print Name and Result for each filtered student
        foreach (var student in passedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Result: {student.Result}");
        }
    }
}
