using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double pedestal;    //variable that will containt the base of the triangle
            double height;      //variable that will containt the height of the triangle
            double result;      //variable that will contain the result
            char choice;        

            AreaOfTriangle area = new AreaOfTriangle();     //Instance for the AreaOfTriangle Class

            start:
            Console.Write("Please input the base : ");      //input from the user phase
            pedestal = double.Parse(Console.ReadLine());
            Console.Write("Please input the height : ");
            height = double.Parse(Console.ReadLine());

            result = area.Area(pedestal, height);

            if (result < 0)
            {
                Console.WriteLine("\nError Encountered !!");      //this what happen when the input negative
                Console.WriteLine("Please re-write your input variable ");
                goto start; //user must re-input the variable when one of the variable was negative
            } else
            {
                Console.WriteLine("\nThe area of triangle : {0}", Math.Round(result, 3)); // the result of the area of triangle
                Console.ReadKey();
            }

            choose:
            Console.Write("Would you like to calculate another area ? (y/n) ");
            choice = char.Parse(Console.ReadLine().ToLower());

            switch (choice)
            {
                case 'y':
                    Console.Clear();
                    goto start;
                    break;
                case 'n':
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Error input");
                    goto choose;
                    
            }

        }
    }
}
