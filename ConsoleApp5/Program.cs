using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void resize(ref int[] arr, int new_size)
        {
            int[] arr_new = new int[new_size];
            for(int i=0; i < Math.Min(arr.Length,new_size); i++)
            {
                arr_new[i] = arr[i];
            }
            arr = arr_new;
        }
        static void reverse(ref int[] arr)
        {
            for(int i = 0; i < arr.Length / 2; i++)
            {
                int c = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = c;
            }
        }
        static void write(in int[] arr)
        {
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("\n");
        }
        static void test(int[] arr, int new_size = -1) 
        {
            resize(ref arr, new_size==-1 ? arr.Length : new_size);

            write(in arr);

            reverse(ref arr);
            write(in arr);
            Console.Write("\n");
        }
        static void add_to_i(ref int[] arr, int index, int val)
        {
            int[] arr_new = new int[arr.Length + 1];
            for(int i = 0; i < index; i++)
            {
                arr_new[i] = arr[i];
            }
            arr_new[index] = val;
            for(int i = index; i < arr.Length; i++)
            {
                arr_new[i+1] = arr[i];
            }
            arr = arr_new;
        }
        static void add_back(ref int[] arr, int val)
        {
            add_to_i(ref arr, arr.Length, val);
        }
        static void add_front(ref int[] arr, int val)
        {
            add_to_i(ref arr, 0, val);
        }
        static void Main(string[] args)
        { const int n = 12;
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                //arr[i] = int.Parse(Console.ReadLine());
                arr[i] = i+1;

            }
            test( arr);
            test( arr, 5);
            test( arr, 20);

             add_to_i(ref arr, 5, 10);
            add_back(ref arr, 10);
            add_front(ref arr, 10);
            write(arr);

            Console.Read();
        }
    }
}
