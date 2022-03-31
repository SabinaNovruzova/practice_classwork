using practice.Models;
using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Novruzova Sebine",700);
            stu.StudentInfo();
            Console.WriteLine("------------------------------------");
            User us = new User("Novruzova Sebine", "sebine@gmail.com", "sebine123");
            us.ShowInfo();
        }
    }
}
