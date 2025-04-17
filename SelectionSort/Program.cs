using System;
using System.Globalization;

namespace MyApp
{
    class Sort
    {
        public void SelectionSort(int[] A, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                int position = i;
                for(int j = i + 1; j < n; j++)
                    if (A[j] > A[position])
                    position = j;
                int temp = A[i];
                A[i] = A[position];
                A[position] = temp;
            }
        }
        
        public void Display(int[] A, int n)
        {
            for(int i = 0; i < n; i++)
                System.Console.Write(A[i] + " ");
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] a = { 3, 5, 8, 9, 6, 2 };
            System.Console.Write("Original Sort: ");
            s.Display(a, 6);
            System.Console.Write("Sorted Array: ");
            s.SelectionSort(a, 6);
            s.Display(a, 6);
        }
    }
}