using System;

namespace Week3Ex6
{
    class Program
    {
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;
            public string yearTotalGrade;

            public module_data[,] modules; // Creates an array called modules holding what will be 6 * module_data.
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
        static void populateStruct(out student_data student, string fname, string surname, int id_number, float averageGrade, string yearTotalGrade, module_data[,] modules)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = averageGrade;
            student.yearTotalGrade = yearTotalGrade;
            student.modules = modules;

            // populateModule(modules, ); // Populating struct
        }
        public static float[] calcAverageGrade(ref module_data[,] modules)
        {
            float addedGrades1 = 0; // 2 Variables to store students seperate data
            float addedGrades2 = 0;
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
                        if (moduleNum == 5) // When the last module is reached, divide all marks added
                            // and stored by the total number of modules. This is to get the average grade.
                            total[0] = addedGrades1 / 6;
                    }
                    else
                        addedGrades2 += singleGrade;
                    if (moduleNum == 5)
                        total[1] = addedGrades2 / 6;
                }
            }
            return total; // Returns array with 2 float values which is the average grade
        }

        // Fail: 0-29, Narrow Fail: 30-39, Pass: 40-49, Good: 50-59, Very Good: 60-69, Excellent: 70-84 and
        // Outstanding: 85-100, method needs to return one of the above.
        public static string [] calcGrade(float [] average) 
        /* Method created to give the student a score from the average grade
         * Method using static string as returns two strings in an array.
         * Method accepts average grade array which contains two float values.
         */
        {
            string[] grade = new string[2]; 
            // Array created to store students mark
            // Returns students relevant grade as a string in an array

            try // To make sure I didn't break the program
            {
                for (int i = 0; i < 2; i++)
                    // Two loops, one for each student
                {
                    if (average[i] <= 100 && average[i] >= 85)
                        // && used to make sure value was in a specfic range between 2 numbers
                        // it ensured the number is smaller or equal to 100 yet bigger or equal to 85
                        grade[i] = "Outstanding: 85 - 100";
                    // If students grade is in the specific range the string is assinged to the respective
                    // student in the array

                    else if (average[i] <= 84 && average[i] >= 70)
                        grade[i] = "Excellent: 70 - 84";
                    else if (average[i] <= 69 && average[i] >= 60)
                        grade[i] = "Very Good: 60 - 69";
                    else if (average[i] <= 59 && average[i] >= 50)
                        grade[i] = "Good: 50 - 59";
                    else if (average[i] <= 49 && average[i] >= 40)
                        grade[i] = "Pass: 40 - 49";
                    else if (average[i] <= 39 && average[i] >= 30)
                        grade[i] = "Narrow Fail: 30 - 39";
                    else if (average[i] <= 29 && average[i] >= 0)
                        grade[i] = "Fail: 00 - 29";
                }
            }
            catch(Exception message) // Tells me what the issue with the code is
            {
                Console.WriteLine(message); // Prints issue identified by visual code studio
                Console.WriteLine("Issue with assgning a grade"); // Explains where code broke so I can come back to this method
            }
            return grade; // Returns array with 2 string variables
        }
        static void Main(string[] args)
        {

            // Trial by arrays;

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

            student_data[] student = new student_data[2];

            float[] averageGrade = calcAverageGrade(ref modules);
            string [] grade = calcGrade(averageGrade);

            populateStruct(out student[0], "Mark", "Anderson", 1, averageGrade[0], grade[0], modules);
            populateStruct(out student[1], "Ardendu", "Behara", 2, averageGrade[1], grade[1], modules);
            // Above calls method to populate relevant student data

            printStudent(ref student); // Calls method that prints all student data

        }
        static void printStudent(ref student_data[] student)
        {
            for (int i = 0; i < 2; i++) // Comment in previous exerise the same
            {
                Console.WriteLine("Name: " + student[i].forename + " " + student[i].surname);
                Console.WriteLine("Id: " + student[i].id_number);
                Console.WriteLine("Av grade: " + student[i].averageGrade + "%");
                Console.WriteLine("This is a " + student[i].yearTotalGrade);

                for (int modNum = 0; modNum <= 5; modNum++)
                {
                    Console.WriteLine("Module " + (modNum + 1) + " Code: " + student[i].modules[i, modNum].moduleCode);
                    Console.WriteLine("Module " + (modNum + 1) + " Title: " + student[i].modules[i, modNum].moduleTitle);
                    Console.WriteLine("Module " + (modNum + 1) + " Mark: " + student[i].modules[i, modNum].moduleMark);
                }
            }
        }
    }
}
