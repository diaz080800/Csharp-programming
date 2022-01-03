/*
 * Week 3 - Exercise 5
 * By Christopher Diaz Montoya
 * ID - 24707686
 */ 

using System;

namespace Week3Ex5
{
    class Program
    {
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;

            public module_data [,] modules; // Creates an array called modules holding what will be 6 * module_data.
        }
        public struct module_data // Creates a struct.
        {
            public string moduleCode; // Creates an empty string variable within the struct.
            public string moduleTitle;
            public int moduleMark;
        }
        static void populateModule(out module_data module, string mcode, string mname, int score) // Method to populate struct
        {
            module.moduleCode = mcode; // The variable passed through the method is assigned to the variable in the struct module_data
            module.moduleTitle = mname;
            module.moduleMark = score;
        }
        // Method below passes a float to predict accurate average grade and jagged array with student data and all their modules
        static void populateStruct(out student_data student, string fname, string surname, int id_number, float averageGrade, module_data [,] modules) 
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = averageGrade;
            student.modules = modules;
        }
        static void Main(string[] args)
        {

            // Jagged arrays to help store 6 modules to 1 student

            module_data[,] modules = new module_data[2, 6];
            // https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array
            populateModule(out modules[0, 0], "200", "Data Mining", 90);
            populateModule(out modules[0, 1], "201", "Data Analytics", 75);
            populateModule(out modules[0, 2], "202", "Statistical Inference", 85);
            populateModule(out modules[0, 3], "203", "Data Modelling", 80);
            populateModule(out modules[0, 4], "204", "Programming: Theory to Practice", 60);
            populateModule(out modules[0, 5], "205", "Employability", 92);

            populateModule(out modules[1, 0], "200", "Data Mining", 40);
            populateModule(out modules[1, 1], "201", "Data Analytics", 35);
            populateModule(out modules[1, 2], "202", "Statistical Inference", 55);
            populateModule(out modules[1, 3], "203", "Data Modelling", 45);
            populateModule(out modules[1, 4], "204", "Programming: Theory to Practice", 40);
            populateModule(out modules[1, 5], "205", "Employability", 70);

            student_data[] student = new student_data[2]; // New array to hold 2 student which each belogn to 1 jagged array

            float[] averageGrade = calcAverageGrade(ref modules); // Calulates average grade

            populateStruct(out student[0], "Mark", "Anderson", 1, averageGrade[0], modules); // Pupulates struct
            populateStruct(out student[1], "Ardendu", "Behara", 2,  averageGrade[1], modules);
            printStudent(ref student); // Calls method to print all student data, passes array as parameter

        }
        static void printStudent(ref student_data [] student) // Array as parameter
        {
            // Outer loop helps identify the student 1 or 2, [] needed to declare data type
            // .surname helps calls the data in the specfic struct which in this case is student
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Name: " + student[i].forename + " " + student[i].surname);
                Console.WriteLine("Id: " + student[i].id_number);
                Console.WriteLine("Av grade: " + student[i].averageGrade + "%");
                // Nested loop prints all modules with code, title and mark for the relevant student in the jagged array
                // student array contains module jagged array, nested loop goes over moduels = i, .module code is data in
                // that location
                for (int modNum = 0; modNum <= 5; modNum++)
                {
                    Console.WriteLine("Module " + (modNum + 1) + " Code: " + student[i].modules[i, modNum].moduleCode);
                    Console.WriteLine("Module " + (modNum + 1) + " Title: " + student[i].modules[i, modNum].moduleTitle);
                    Console.WriteLine("Module " + (modNum + 1) + " Mark: " + student[i].modules[i, modNum].moduleMark);
                }
            }
        }
        
        public static float [] calcAverageGrade(ref module_data[,] modules)
        {
            float addedGrades1 = 0; // 2 Variables to store students seperate data
            float addedGrades2 = 0; // Float used to save memorey but get a decimal average 
            float[] total = new float[2]; // Return type will be an array of 2 floats for the 2 students

            for (int studentNum = 0; studentNum < 2; studentNum++) // Itertes over each student = 2 loops.
            {
                for (int moduleNum = 0; moduleNum < 6; moduleNum++) // Iterates over each modules = 6 loops in EACH of the 2 loops
                {
                    int singleGrade = modules[studentNum, moduleNum].moduleMark; 
                    /* Above gets each individual grade of each student, the single grade is stored.
                     * The student Num is either the first or second student, the moduleNum is 1 of the 
                     * 6 modules being looped over and the .moduleMark is calling the individual module
                     * mark present in the allocated student and module. the modules before t
                     * is calling the populated struct presented as a 2d array.
                     */

                    if (studentNum == 0) // If it is the first student in the 2d array
                    {
                        addedGrades1 += singleGrade; 
                        /* Each module marked is looped and stored in singleGrade. 
                         * This value is emptied and restored each loop.
                         * Before it is ressigned a new value the relevent students grades
                         * are all added in addedGrades1 with +=
                         */
                        if(moduleNum == 5) // When the last module is reached, divide all marks added
                            // and stored by the total number of modules. This is to get the average grade.
                            total[0] = addedGrades1/6; 
                    }
                    else 
                        addedGrades2 += singleGrade;
                        if(moduleNum == 5) // When all modules grades added
                            total[1] = addedGrades2/6; // Divide by 6 for the average
                }
            }
            return total; // Returns array with 2 float values which is the average grade
        }
    }
}
