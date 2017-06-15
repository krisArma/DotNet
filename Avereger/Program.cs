using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avereger
{
    class Program
    {
        static void Main(string[] args)
        {
            int index; //variable that contain an index of an array

            Avereger avereger = new Avereger();     //instance of the Avereger Class

            Console.Write("How many number you want to be avarage : ");
            index = int.Parse(Console.ReadLine());

            double[] array = new double[index];     //declaration of array variable
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("input the #{0} number(s) : ", i + 1);
                array[i] = double.Parse(Console.ReadLine());    //inputing the value of array one-by-one
            }

            avereger.Averege(array);    //call the avereger method of Avereger class
        }
    }
}
