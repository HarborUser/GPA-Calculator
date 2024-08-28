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
             Console.WriteLine("Your GPA for Clas: "+ (3.0));
        }
        
        if(arg1 == "A")
        {
             Console.WriteLine((4.0));
        }


    }
    public static void Main()
    {
        //int CGPA =0;
        
        Console.Write("Enter number of course take: ");
        int course_taken = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You have taken "+ course_taken + " course");
        MainClass obj = new MainClass();
        string course_name;
        string course_string_grade;
        //string[] course = new string[course_taken];
        string[] course = new string[10];
        string [] course_grade  = new string[10];

        for(int i = 0; i < course_taken; i++)
        {
           
            Console.Write($"Enter the name for course: ");
            course_name = Console.ReadLine();
            course[i] = course_name;

            Console.Write("Enter the grade for course: \n");
            course_string_grade = Console.ReadLine();
            course_grade[i] = course_string_grade;
            

            Console.Write($"Whats the name of course no: {i+1} = {course[i]} \n");
            obj.convertLetterGradeIntoPointGrade(course_grade[i]);
           
 



        } 
        Console.Write($"Here the name {course[0]} for {course_taken} ");
        //obj.inputCourseNameAndGrade(,"B");
        obj.convertLetterGradeIntoPointGrade("A");
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

