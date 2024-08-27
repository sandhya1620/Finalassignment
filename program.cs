using System;
using System.Linq;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ensure the database is created
            using (var context = new StudentContext())
            {
                context.Database.EnsureCreated();

                // Create a new Student instance
                var student = new Student
                {
                    Name = "John Doe"
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                // Retrieve and display the student
                var savedStudent = context.Students.FirstOrDefault();
                Console.WriteLine($"Student ID: {savedStudent.Id}, Name: {savedStudent.Name}");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}