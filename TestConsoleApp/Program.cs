// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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

   

    public void yourGPAfromGrades(string [] course_grade)
    {




    }
    public static void Main()
    {
        //int CGPA =0;
        
        Console.Write("Enter number of course take: ");
        int course_taken = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have taken "+ course_taken + " course");
        MainClass obj = new MainClass();
        string ?course_name;
        string ?course_string_grade;
        //string[] course = new string[course_taken];
        string[] course= new string[10];
        string [] course_grade  = new string[10];
        float [] course_int_grade = new float[10];

        for(int i = 0; i < course_taken; i++)
        {
            
            Console.Write($"Enter the name for course: ");
            course_name = Console.ReadLine();
            course[i] = course_name ?? "Empty Course Name";

            Console.Write("Enter the grade for course: ");
            course_string_grade = Console.ReadLine();
            course_grade[i] = course_string_grade ?? "E";
            

            Console.Write($"Whats the name of course no: {i+1} = {course[i]} \n");
            course_int_grade[i] = obj.convertLetterGradeIntoPointGrade(course_grade[i]);

        } 
        Console.WriteLine(course[1]);

        for(int j= 0; j<course_taken; j++)
        {
            Console.WriteLine(course_int_grade[j]);
        }
       
    }

     public float convertLetterGradeIntoPointGrade(string arg1)
    {
        float arg2 = 1.0F;
        if(arg1 == "B")
        {
            Console.WriteLine("Your GPA for Class: "+ (3.0));
            arg2 = 3.0F;
            
            
        }
        
        if(arg1 == "A")
        {
             Console.WriteLine("Your GPA for Class: "+ (4.0));
            arg2 = 4.0F;
        }
        return arg2;


    }

    


}

