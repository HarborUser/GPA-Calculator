// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("Hello, World!");
/* Take in user input, number of course, and grades earned each             */
MainClass.Main();

class MainClass
{
    public static void Main()
    {
        int CGPA =0;
        
        Console.Write("Enter number of course take: ");
        int course_taken = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have taken "+ course_taken + " course");

        bool ValidString = true;
        while(ValidString)
        {
            if(course_taken > 0)
            {
                Console.Write($"Enter the grade for course {course_taken} ");
                int course_grade = Convert.ToInt32(Console.ReadLine());
                course_taken -= 1;
            }
            else
            {
                ValidString = false;
            }
            

        }
    }

    public void courseRecords(string course_name,string course_grade)
    {
        Dictionary<string,string> courses = new Dictionary<string, string>();
        courses.Add(course_name,course_grade);
    
       
    }


}

