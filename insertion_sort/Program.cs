using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length : ");
            int len = int.Parse(Console.ReadLine());


            int[] array = new int[len];
            Console.Write("Enter array elements : ");

            //take the element from user
            for (int i = 0; i < len; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Insertion_sort(array, array.Length);
            print(array, array.Length);
        }

        static void Insertion_sort(int[] arry ,int n)
        {
            int check, j;
            for(int i=1; i<arry.Length; i++)
            {
                check = arry[i];
                j = i - 1;
                 
                while(j >= 0 && arry[j]>check)
                {
                    arry[j+1]=arry[j];
                    j -= 1;
                }
                arry[j+1] = check;
            }
        }

        static void print(int[] arry,int n)
        {
            Console.Write("The sorted array is : ");
            for(int i=0; i<arry.Length; i++)
            {
                
                Console.Write(arry[i] + " ");
            }
        }
    }
}
