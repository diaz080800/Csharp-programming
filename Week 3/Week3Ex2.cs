/* 
 * Week 3 - Exercise 2
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Week3Ex2
{
    class Program
    {
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;
            public string programTitle; // Created the two variables asked to add to struct.
            public string programCode; // Both of type string.
        }
        static void populateStruct(out student_data students, string fname, string surname, int id_number, string programTitle, string programCode)
        { // Parametereized constructor, void does not return a type just populates struct.
            /*
             * student = student_data struct. This is a reference to the struct. The full stop after students calls that specific 
             * variable within student_data struct. It then assigns into the struct whatever it is = too.
             * This is because the out keyword changes the values to whatever is passed thorugh the parameter.
             */
            students.forename = fname;
            students.surname = surname;
            students.id_number = id_number;
            students.averageGrade = 0.0F;
            students.programTitle = programTitle;
            students.programCode = programCode;
        }
        static void Main(string[] args)
        {
            // Creates an array which holds 4 items.
            student_data [] students = new student_data [4];
            /* 
             * Calls method populateStruct and populates struct stored in index [x] with the data next to it, according to
             * parameter order in method and order in method call. 
             */
            populateStruct(out students [0], "Mark", "Anderson", 1, "Computer Science", "204");
            populateStruct(out students [1], "Ardhendu", "Behera", 2, "Artificial Intelligence", "205");
            populateStruct(out students [2], "Tom", "Jones", 3, "Computer Science", "204");
            populateStruct(out students [3], "Ewan", "Evans", 4, "Artificial Intelligence", "205");

            printAllStudents(ref students); // Calls and runs method to print data, passes whole array.
        }

        // Method below of type void as it prints out and does not return a value, type declared in parameter.
        // ref word used to find location in memory and pass through data, saving memory.
        static void printAllStudents(ref student_data [] students) 
        {
            // for loop used to iterate thorugh all 4 students, i only goes up to 3 as indexing starts count from 0.
            for (int i = 0; i < 4; i++) // After each loop i is += 1 so loops over all students in array.
            {
                /*
                 * students[i] = populated student_data struct within array.
                 * students[i], as loop increments so does i looping through all students indexed in array.
                 * The full stop after students[i] calls that specific variable within the specific array index holding 
                 * students data within the struct.
                 */ 
                Console.WriteLine("Name: " + students[i].forename + " " + students[i].surname);
                Console.WriteLine("Id: " + students[i].id_number);
                Console.WriteLine("Av grade: " + students[i].averageGrade);
                Console.WriteLine("Program title: " + students[i].programTitle);
                Console.WriteLine("Prgram code: " + students[i].programCode);
            }
        }
    }
} 
