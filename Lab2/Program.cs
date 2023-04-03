using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<Student> students = GetStudentsFromDatabase();

        
        List<Student> filteredStudents = students.Where(student => student.AverageGrade >= 4.5).ToList();

        
        Console.WriteLine("Filtered students:");
        foreach (Student student in filteredStudents)
        {
            Console.WriteLine("{0} {1}, Average grade: {2}", student.FirstName, student.LastName, student.AverageGrade);
        }

        Console.ReadLine();
    }

    static List<Student> GetStudentsFromDatabase()
    {
        
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<double> Grades { get; set; }

    public double AverageGrade
    {
        get { return Grades.Average(); }
    }
}
