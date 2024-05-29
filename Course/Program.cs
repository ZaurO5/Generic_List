using System;

public class Program
{
    public static void Main()
    {
        Course course = new Course();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Remove a student");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Search for a student");
            Console.WriteLine("5. Count total students");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter student surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Enter student age: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.Write("Enter student PIN: ");
                        string pin = Console.ReadLine();
                        Student student = new Student(name, surname, age, pin);
                        course.AddStudent(student);
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Please enter a valid integer.");
                    }
                    break;

                case "2":
                    Console.Write("Enter student PIN to remove: ");
                    string pinToRemove = Console.ReadLine();
                    course.RemoveStudent(pinToRemove);
                    break;

                case "3":
                    course.DisplayAllStudents();
                    break;

                case "4":
                    Console.Write("Enter student PIN to search: ");
                    string pinToSearch = Console.ReadLine();
                    course.SearchStudent(pinToSearch);
                    break;

                case "5":
                    Console.Write("Enter the minimum age to count students above: ");
                    if (int.TryParse(Console.ReadLine(), out int minAge))
                    {
                        int count = course.CountTotalStudentsAboveAge(minAge);
                        Console.WriteLine($"Total students above {minAge} years old: {count}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Please enter a valid integer.");
                    }
                    break;

                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }
    }
}
