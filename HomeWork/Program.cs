
using HomeWork.Domain.Domain;
using HomeWork.Domain.Models;

#region TASK1
User user1 = new User("nadir@gmail.com", "Nadir123");
user1.FullName = "Nadir Shirinbayli";
user1.ShowInfo();


User user2 = new("nadir@gmail.com", "adir123");
user2.FullName = "Nadir Shirinbayli";
user2.ShowInfo();



User user3 = new("nadir@gmail.com", "Nadir123");
user3.ShowInfo();

User user4 = new("Nadirgmail.com", "Nadir123");
user4.ShowInfo();

User user5 = new("Nadir@gmail.com", "Nadir123");
user5.ShowInfo();

#endregion

#region TASK2
Console.WriteLine("----------------------TASK2--------------------------");
Student student1 = new()
{
    FullName = "Nadir Shirinbayli",
    Point = 55,
};
student1.StudentInfo();

Student student2 = new()
{
    FullName = "ELI Eliyev",
    Point = 65,
};
student2.StudentInfo();
#endregion