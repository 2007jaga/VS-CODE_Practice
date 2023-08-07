// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using CMS.UI.Models;

namespace CMS.Application
{
    class Program
    {

        static List<Student> students = new List<Student>();

        static void Main(String[] args)
        {
            students.Add(new Student(101, "Jaga", "11"));

            students.Add(new Student(102, "Jaga2", "12"));

            students.Add(new Student(102, "Jaga2", "12"));

            students.Add(new Student(103, "Jaga3", "13"));


            foreach (var s in students)
            {
                System.Console.WriteLine("test");
                Console.WriteLine("Test" + s._Age);
            }
        }

    }

}