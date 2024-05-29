using System;
using System.Collections.Generic;
using System.Linq;

public class Course
{
    private List<Student> students;

    public Course()
    {
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        if (!students.Exists(s => s.PIN == student.PIN))
        {
            students.Add(student);
            Console.WriteLine($"Student {student.Name} added.");
        }
        else
        {
            Console.WriteLine($"A student with the same PIN '{student.PIN}' already exists and was not added.");
        }
    }

    public void RemoveStudent(string pin)
    {
        Student student = students.FirstOrDefault(s => s.PIN == pin);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"Student {student.Name} removed.");
        }
        else
        {
            Console.WriteLine($"Student with PIN '{pin}' not found.");
        }
    }

    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students in the course.");
            return;
        }

        Console.WriteLine("Students in the course:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    public void SearchStudent(string pin)
    {
        Student student = students.FirstOrDefault(s => s.PIN == pin);
        if (student != null)
        {
            Console.WriteLine($"Student found: {student}");
        }
        else
        {
            Console.WriteLine($"Student with PIN '{pin}' not found.");
        }
    }

    public int CountTotalStudentsAboveAge(int age)
    {
        return students.Count(s => s.Age > age);
    }
}
