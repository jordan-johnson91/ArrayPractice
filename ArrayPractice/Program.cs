using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array 
            //DataType[] nameOfArray = { elements};
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            //Console.WriteLine(students[5]);
            //Console.WriteLine(students[0]);
            //Top 10 vacation spots
            //Print out first and last 
            string[] vacationSpots = { "Japan", "Florida", "Texas", "Napa Valley", "San-Fran" };
            //Console.Write(vacationSpots[0]);
            //Console.Write(vacationSpots[vacationSpots.Length-1]);
            //Ages of 3 children 
            //print each childs age
            int[] ages = { 1, 15, 19 };
            //Console.WriteLine(ages[0]);
            //Console.WriteLine(ages[1]);
            //Console.WriteLine(ages[2]);
            //Gpa on a 4.0 scale of 8 students
            //When you DONT KNOW the elements of your array up front
            //datatype[] nameOfArray = new dataType[#ofElements];
            float[] gpa = new float[8];
            gpa[0] = 4.0f;
            gpa[1] = 3.5f;
            //first letter of your peers names who are sitting next to you 
            char[] letter = { 'b', 's', 's' };
            //Console.WriteLine(letter);
            //Console.WriteLine(ages);

            //Declare and Initalize an array for the days of the week 
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //Declare and Initslize an array of student ages use the NEW keyword 
            int[] studentAges = new int[3];
            studentAges[0] = 15;
            studentAges[1] = 25;
            studentAges[2] = 28;
            //Console.WriteLine(daysOfTheWeek.Length);
            //Console.WriteLine(daysOfTheWeek[0]);
            //daysOfTheWeek.SetValue("Funday", 0);
            //Console.WriteLine(daysOfTheWeek[0]);
            //string[] birthMonths = { "December", "July", "May", "July" };
            //Console.WriteLine(Array.IndexOf(birthMonths,"July"));
            //Console.WriteLine(Array.LastIndexOf(birthMonths,"July"));

            //int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            //Console.WriteLine(numbers[0]);
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length-1]);




            string[] firstNames = new string[5];
            firstNames[0] = "Jordan";
            firstNames[1] = "Carrie";
            firstNames[2] = "Jarryd";
            firstNames[3] = "Kacy";
            firstNames[4] = "Mel";
           
            //Console.WriteLine(Array.IndexOf(firstNames, "Mel"));

            //char[] alphabet = { 'a', 'b', 'c' };
            //Console.WriteLine(alphabet[0]);
            
            //Array.Reverse(alphabet);
            //Console.WriteLine(alphabet[0]);

            //string[] studentsInClass = { "Daniel", "Max", "Joyce", "Richard","adam" };
            //Console.WriteLine( studentsInClass[0]);
            //Array.Sort(studentsInClass);
            //Console.WriteLine(studentsInClass[0]);

            int[] favNumbers = { 15, 7, 22, 5, 43, 45, 23, 3, 42, 17 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0] + " " + favNumbers[favNumbers.Length-1]);
        }
    }
}
