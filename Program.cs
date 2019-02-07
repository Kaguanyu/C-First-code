using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
           /* Console.WriteLine("Hello World!");
           // string country;
          
           Console.ReadLine();
             Console.Write("The country is: ");
            Console.WriteLine(country);
            char joh='k';
            Console.Write("The character is: ");
           Console.WriteLine(joh);
           double marks = 70.44;
           Console.Write("The marks is: ");
         Console.WriteLine(marks);
         float catscore = 13.1334F;
         Console.Write("The catscore is: ");
          Console.WriteLine(catscore);*/
          int students = 45;
          Console.WriteLine("Enter the number of student");
          students = Convert.ToInt32(Console.ReadLine());
          
         
     
        //  decimal unit = 54.344M;
        //  Console.Write("The number of unit is: ");
          
           string country;
          Console.WriteLine("I want some value");
          country = Console.ReadLine();
         // Console.WriteLine(unit);
         Console.WriteLine(country);
         Console.WriteLine(students);
         int result = country + 5;
            Console.ReadKey();
        }
    }
}