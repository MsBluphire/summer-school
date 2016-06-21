using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static string[] Students = new string[15];

        public static object Exit { get; private set; }

        static void Main(string[] args)

        /*Beginning menu with all options listed
        *Option 1 Enroll Student -- method
        *Need to be able to add a student to the list in an available spot
        *Option 2 Unenroll Student -- method
        *Need to be able to remove a student from the list for an available spot
        *Option 3 Print Student List -- method
        *Need to be able to print a list of all students including money owed
        *Option 4 Exit -- Stop or Break
        */

        {
          
                
            //actual Menu user would see

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. Print Student List");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Addstudent();
                    break;

                case 2:
                    Removestudent();
                    break;

                case 3:
                    Printstudent();
                    break;

                default:
                    Console.WriteLine("Please choose option 1, 2, 3 or 4");
                    break;
            }

            Console.ReadKey();
        }

        static void Printstudent()
        {
            for (int i = 0; i < Students.Length; i++);
            {
                Console.Write(Students);
              
            }
            Console.Read();
        }



        private static void Removestudent()
        {
            Console.WriteLine("Please select a student to remove");
            string student = Console.ReadLine();

           

        }

        private static void Addstudent()
        {
            Console.WriteLine("Please enter student name");
            string student = Console.ReadLine();

            int spot = NextSpot();
                Students[spot] = student;
        }

        private static int NextSpot()
        {
            for(int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null);
                {
                    return i;
                }
            }
            return -1;
        }
    }
        }






