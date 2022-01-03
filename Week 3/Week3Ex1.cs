/*
 * Week 3 - Exercise 1
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3Ex1
{
    class Program
    {
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;
            public string moduleTitle; // Created the two variables asked to add to struct.
            public string moduleCode; // Both of type string.
        }
        static void populateStruct(out student_data student, string fname, string surname, int id_number, string mTitle, string mCode)
        { // Parametereized constructor, void does not return a type just populates struct.
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0F;

            /*
             * student = student_data struct. This is a reference to the struct. The full stop after student calls that specific 
             * variable within student_data struct. It then assigns into the struct whatever it is = too.
             * This is because the out keyword changes the values to whatever is passed thorugh the parameter.
             */
            student.moduleTitle = mTitle;
            student.moduleCode = mCode;
        }
        static void Main(string[] args)
        {
            // Code below given in exercise
            student_data student1, student2; // Creates two structs storing seperate values

            /* 
             * Calls method and populates student1 struct with data next to it, according to
             * parameter order in method. "Computer science" and "203" were added to populate the relevant
             * variable, in the same order moduleTitle and moduleCode
             */ 

            populateStruct(out student1, "Mark", "Anderson", 1, "Computer Science", "203");
            printStudent(student1); // Calls and runs method to print data
            populateStruct(out student2, "Ardendu", "Behara", 2, "Artificial Intelligence", "204");
            printStudent(student2);
        }
        public static void printStudent(student_data student)
        {
            Console.WriteLine("Name: " + student.forename + " " + student.surname);
            Console.WriteLine("Id: " + student.id_number);
            Console.WriteLine("Av grade: " + student.averageGrade);

            /*
            Below added a writeline method to print a string of the relevant data being printed
            + the relevant data.
            student = populated student_data struct (in this case it should br filled,
            otherwise there was an issue with populateSruct.
            The full stop after student calls that specific variable within the struct.
             */
            Console.WriteLine("Module Title: " + student.moduleTitle);
            Console.WriteLine("Module Code: " + student.moduleCode);
        }
    }
}
