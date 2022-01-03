/*
 * Week 3 - Exercise 4
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Week3Ex4
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

            // Creates an array called modules holding what will be 6 * module_data for each student.
            public module_data [,] modules; 
        }
        public struct module_data // Creates a struct.
        {
            public string moduleCode; // Creates an empty string variable within the struct.
            public string moduleTitle;
            public int moduleMark;
        }
        // Method below of type void, does not return or print, only populates struct.
        static void populateModule(out module_data module, string mcode, string mname, int score) // Method to populate struct given
        {
            module.moduleCode = mcode; // The variable passed through as a parameter is assigned to the variable in the struct module_data
            module.moduleTitle = mname;
            module.moduleMark = score;
        }
        // Allowed method below to also accept a 2d array.
        static void populateStruct(out student_data student, string fname, string surname, int id_number, module_data [,] modules) 
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0F;
            student.modules = modules;
        }
        static void Main(string[] args)
        {
            // Created a 2D array, [x,i], x = rows, y = columns
            module_data [,] modules = new module_data[2,6];

            // Below poppulating jagged array so one row is for one student and each row has a column with relevant data
            populateModule(out modules[0,0], "200", "Data Mining", 90);
            populateModule(out modules[0,1], "201", "Data Analytics", 75);
            populateModule(out modules[0,2], "202", "Statistical Inference", 85);
            populateModule(out modules[0,3], "203", "Data Modelling", 80);
            populateModule(out modules[0,4], "204", "Programming: Theory to Practice", 60);
            populateModule(out modules[0,5], "205", "Employability", 92);

            populateModule(out modules[1,0], "200", "Data Mining", 40);
            populateModule(out modules[1,1], "201", "Data Analytics", 35);
            populateModule(out modules[1,2], "202", "Statistical Inference", 55);
            populateModule(out modules[1,3], "203", "Data Modelling", 45);
            populateModule(out modules[1,4], "204", "Programming: Theory to Practice", 40);
            populateModule(out modules[1,5], "205", "Employability", 70);

            // Created an array for students, only 2 as only 2 students in example 1
            student_data[] student = new student_data[2];

            // populating struct and storing in array[x], passing 2d array into student array.
            populateStruct(out student[0], "Mark", "Anderson", 1, modules);
            populateStruct(out student[1], "Ardendu", "Behara", 2, modules);

            // method called to print all student data, only need to pass 1 array as is all stored inside.
            printStudent(ref student);
        }
        // Method returns nothing so type void, accepts an array storing struct data.
        public static void printStudent(ref student_data [] student)
        {   
            // For loop to loop over the 2 students, only runs two loops.
            for (int i = 0; i < 2; i++)
            {
                // As loop only runs twice i in first loop is 0 and then in last loop is 1 calling student in that index.
                // the fullstop in student[i].forename, calls that varible stored in that indexed arrays struct.
                Console.WriteLine("Name: " + student[i].forename + " " + student[i].surname);
                Console.WriteLine("Id: " + student[i].id_number);
                Console.WriteLine("Av grade: " + student[i].averageGrade);

                // Nested for loop, for each time the outer above loop runs once this runs 6 times.
                // modNum inceremnets by 1 each loop until reaches 5, counts from 0.
                for (int modNum = 0; modNum <= 5; modNum++)
                {
                    /* Below prints out (modnum+1) as counter starts from 0 and want to say module 1 in the first loop.
                     * student[i] is the student we are on in the outer loop, the student[i].modues[i,modNum] is to call the 
                     * module_data struct in the student_data struct. [i, modNum], the i is to identifiy the row aka student
                     * and the modNum is to iterate and print over the columns for the respective student. i does not change 
                     * during the nested loop so each nested loop onky focuses on 1 student until requirements met, and can 
                     * move onto outter loop for the next student.
                     * The final bit student[i].modules[i,modNum].moduleCode, the .moduleCode access' the specific variable 
                     * wanted from the 2d array in the module_data struct within the student_data struct.
                     */

                    Console.WriteLine("Module " + (modNum + 1) + " Code: " + student[i].modules[i,modNum].moduleCode);
                    Console.WriteLine("Module " + (modNum + 1) + " Title: " + student[i].modules[i,modNum].moduleTitle);
                    Console.WriteLine("Module " + (modNum + 1) + " Mark: " + student[i].modules[i,modNum].moduleMark);
                }
            }
        }
    }
}
