using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class BubbleSort
    {
        //this class is class that sortir the array into a sorten array from ascending to descending
        public void Sort (int[] array)
        {
            int length = 0;     //this will held the length of the array
            int temp = 0;       //this will held the temporary value of an array value that will switches the place

            for(int write = 0; write < array.Length; write++) //this is bubble sort algorithm
            {
                for(int sort = write + 1; write < array.Length + 1 ; sort++)
                {
                    if (sort < array.Length)
                    {
                        if (array[sort] > array[write])
                        {
                            temp = array[sort];         //When the value of index array greater than the value of the next index
                            array[sort] = array[write];  //the next value will be held in the temporary variable
                            array[write] = temp;             //and the now-indexed value will replace the next value of array
                        }
                    } else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("\nThe sorted array : ");
            for (int i = 0; i < array.Length ; i++)
            {
                //this for-form used to printout the array
                Console.WriteLine(array[i]);
                
            }
            Console.WriteLine("The biggest is : {0}", array[0]);    //printout the biggest number of the array
            Console.WriteLine("The smallest is : {0}", array[array.Length - 1]);    //printout the smallest number of the array
            Console.WriteLine("The biggest number is {0} ", array[0] > 0 ? "positive" : "negative");    //print and check for the biggest number is it negative or positive
            Console.WriteLine("The smallest number is {0} ", array[array.Length - 1] > 0 ? "positive" : "negative"); //print and check for the smallest number it is negative or positive

            Console.Read();
        }
    }
}
