using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;  //this variable will held the total index of user-input

            Console.Write("Please write your total index : ");
            index = int.Parse(Console.ReadLine());  //When the user input the total index

            int[] array = new int[index];   //this array which will held the values

            BubbleSort bubble = new BubbleSort();   //Instance of Bubblesort class


            for (int i = 0; i < index; i++)
            {
                Console.Write("Enter the #{0} value ", i+1);    //The input user of the array
                array[i] = int.Parse(Console.ReadLine());
            }

            bubble.Sort(array);     //the array become a parameter of the bubbleSort
                                    //Next to the BubbleSort class
        }
    }
}
