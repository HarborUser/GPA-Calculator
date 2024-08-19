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
    Dictionary<string,string> courses = new Dictionary<string, string>();
    public void inputCourseNameAndGrade(string course_name,string course_grade)
    {
       
        courses.Add(course_name,course_grade);
        foreach (KeyValuePair<string, string> course_new in courses)
        {
            Console.WriteLine("Course: {0} \nGrade: {1}",course_new.Key, course_new.Value);
        }
    
       
    }

    public void convertLetterGradeIntoPointGrade(string arg1)
    {
        if(arg1 == "B")
        {
             Console.WriteLine((3.0));
        }

    }
    public static void Main()
    {
        //int CGPA =0;
        
        Console.Write("Enter number of course take: ");
        int course_taken = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have taken "+ course_taken + " course");
        MainClass obj = new MainClass();

        obj.inputCourseNameAndGrade("Linear Alegbra",obj.convertLetterGradeIntoPointGrade("B"));
        obj.convertLetterGradeIntoPointGrade("B");
        //bool ValidString = true;
        //inputCourseNameAndGrade myObj = new inputCourseNameAndGrade("A","B");
        //inputCourseNameAndGrade("A","B");
        /* for(int i = 0, i < course_taken; i++)
        {
            Dictionary<int,string> My_dict1 = new Dictionary<int,string>();
            My_dict1.Add()
        } */
        /* while(ValidString)
        {
            if(course_taken != course_taken)
            {
                Console.Write($"Enter the grade for course: {course_taken} ");
                string course_grade = Console.ReadLine();
                course_taken -= 1;
            }
            else
            {
                ValidString = false;
            }
            

        } */
    }

    


}

