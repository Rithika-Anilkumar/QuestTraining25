using System;

namespace Student 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a college student
            var collegeStudent = new CollegeStudent();
            collegeStudent.CollegeName = "ABC College";
            collegeStudent.Name = "Nia";
            collegeStudent.Email = "245@yahoo.com";
            collegeStudent.Address = new Address { Line1 = "123 WhiteField", Line2 = "Apt 4B", Pin = "670308" };

            // Create a school student
            var schoolStudent = new SchoolStudent();
            schoolStudent.SchoolName = "St.Antony's";
            schoolStudent.Name = "Bryan";
            schoolStudent.Email = "123@gmail.com";
            schoolStudent.Address = new Address { Line1 = "VietLa", Line2 = "HouseNo 48", Pin = "670305" };

            // Display the students
            Console.WriteLine(collegeStudent);
            Console.WriteLine(schoolStudent);
        }
    }
}