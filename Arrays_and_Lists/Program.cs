using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            // Selection Sorting 
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            SelectionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.ReadLine();

            float[] floatValues = { -11.2f, 12.56f, -42.59f, 0.0f, 1.1f, 90.9f, 68.68f, 6.1f, -9.8f };
            SelectionSort.Sort(floatValues);
            Console.WriteLine(string.Join(" | ", floatValues));
            Console.ReadLine();

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            SelectionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.ReadLine();


            //Insertion Sorting 

            int[] integerValue = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            InsertionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.ReadLine();

            float[] floatValue = { -11.2f, 12.56f, -42.59f, 0.0f, 1.1f, 90.9f, 68.68f, 6.1f, -9.8f };
            InsertionSort.Sort(floatValues);
            Console.WriteLine(string.Join(" | ", floatValues));
            Console.ReadLine();

            string[] stringValue = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            InsertionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.ReadLine();


            // Bubble Sorting
            int[] integerValuess = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            BubbleSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.ReadLine();


            float[] floatValuess = { -11.2f, 12.56f, -42.59f, 0.0f, 1.1f, 90.9f, 68.68f, 6.1f, -9.8f };
            BubbleSort.Sort(floatValues);
            Console.WriteLine(string.Join(" | ", floatValues));
            Console.ReadLine();


            string[] stringValuess = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            BubbleSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.ReadLine();



            // Quick Sorting
            int[] integerValuesQ = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            QuickSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.ReadLine();

            float[] floatValuesQ = { -11.2f, 12.56f, -42.59f, 0.0f, 1.1f, 90.9f, 68.68f, 6.1f, -9.8f };
            QuickSort.Sort(floatValues);
            Console.WriteLine(string.Join(" | ", floatValues));
            Console.ReadLine();

            string[] stringValuesQ = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            QuickSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.ReadLine();
        }

        static void SelectionTest()
        {
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            SelectionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.ReadLine();
            
        }


        static void InsertionTest()
        {
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            InsertionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));

            float[] floatValues = { -11.2f, 12.56f, -42.59f, 0.0f, 1.1f, 90.9f, 68.68f, 6.1f, -9.8f };
            InsertionSort.Sort(floatValues);
            Console.WriteLine(string.Join(" | ", floatValues));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            InsertionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }


        static void BubbleTest()
        {
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            BubbleSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));

            float[] floatValues = { -11.2f, 12.56f, -42.59f, 0.0f, 1.1f, 90.9f, 68.68f, 6.1f, -9.8f };
            BubbleSort.Sort(floatValues);
            Console.WriteLine(string.Join(" | ", floatValues));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            BubbleSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }


        static void QuicksortTest()
        {
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            QuickSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));

            float[] floatValues = { -11.2f, 12.56f, -42.59f, 0.0f, 1.1f, 90.9f, 68.68f, 6.1f, -9.8f };
            QuickSort.Sort(floatValues);
            Console.WriteLine(string.Join(" | ", floatValues));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            QuickSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }


    }
}
