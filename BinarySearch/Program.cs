using System;

namespace MyApp
{
    public class Search
    {
        public int BinarySearch(int[] a, int n, int key)
        {
            int left = 0;
            int right = a.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (a[mid] == key)
                    return mid;
                if (a[mid] > key)
                    left = mid + 1;
                if (a[mid] < key)
                    right = mid - 1;
            }

            return -1; // Não encontrado
        }

        static void Main(string[] args)
        {
            Search s = new Search();
            int[] a = { 1, 23, 41, 50, 66, 78, 95 };
            int found = s.BinarySearch(a, 7, 50);  
            System.Console.WriteLine(found);

        }
    }

}
