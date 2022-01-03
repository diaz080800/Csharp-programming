/*
 * Week 3 - Exercise 3
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Week3Ex3
{
    class Program
    {
        // Struct
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;
            public string programTitle;
            public string programCode;
        }
        static void populateStruct(out student_data students, string fname, string surname, int id_number, string programTitle, string programCode)
        { // Parametereized constructor, void does not return a type just populates struct

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
            Console.WriteLine("Please enter the number of students: "); // Prompts user for input
            int numStudents = Convert.ToInt16(Console.ReadLine()); // Reads above line and
                                                                   // converts input to integer
            int id;
            string firstName, surname; // Variables created to store values

            // Creates array which will be the size of whatever number the user inputs
            student_data[] students = new student_data[numStudents];

            // For loop that only goes up to whatever the input value is, counter increments by 1 each loop.
            for (int a = 0; a < numStudents; a++)
            {
                // a + 1 is in brackets so this is worked out first, it is counter plus 1 as a loops
                // starting from 0 and we want it to say 1.
                Console.WriteLine("Person " + (a + 1) + ", please enter your name: ");
                // Assigns users name inputted to firstName
                firstName = Console.ReadLine();
                
                Console.WriteLine("Person " + (a + 1) + ", please enter your surname: ");
                // Asigns users surname inputtes to surname
                surname = Console.ReadLine();

                Console.WriteLine("Person " + (a + 1) + ", please enter your id: ");
                // Assigns users id inputted to id, converts input to int.
                id = Convert.ToInt16(Console.ReadLine()); // ToInt16 used to save memory
                populateStruct(out students[a], firstName, surname, id, "Computer Science", "200");
            }
            printAllStudents(ref students); // Calls and runs method to print all data.
        }
        // Method below of type void as it prints out and does not return a value, type declared in parameter struct[] calledStudents.
        // ref word used to find location in memory and pass through data, saving memory.
        static void printAllStudents(ref student_data[] students)
        {
            // for loop up to amount of users input which createdsize of array, hence checking is smaller then students.Length.
            // Incremenets by 1 each loop until all elements in student.Length.
            for (int i = 0; i < students.Length; i++)
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
                Console.WriteLine("Module name: " + students[i].programTitle);
                Console.WriteLine("Module code: " + students[i].programCode);
            }
        }
    }
}
