using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avereger
{
    class Avereger
    {
        //this class will count the average of random number inputed by user
        //the total number depends on the user

        public void Averege(double[] array)
        {
            double result = 0;  //this variable will containt the result (average of the number)

            for(int i = 0; i < array.Length; i++)
            {
                result += array[i]; //this step will continous adding the result value with the value of the array
            }

            Console.WriteLine("The average of : ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length -1)
                {
                    Console.Write(" + ");   //this for-if form just to print value1 + value2 +.... =
                }
            }
            Console.Write(" = {0}", Math.Round((result / array.Length), 3)); //finally print the result rounded by 3 point
            Console.ReadKey();
        }
    }
}
