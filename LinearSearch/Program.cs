using System;

namespace MyApp
{
    internal class Search
    {
        static int LinearSearch(int[] a, int n, int key)
        {
            int index = 0;
            while(index < n)
            {
                if(a[index] == key)
                    return index;
                index++;
            }
            return -1;
        }
        
        static void Main(string[] args)
        {
            int[] a = {2, 23, 44, 56, 72, 88, 90};
            int found = LinearSearch(a, 7, 88);
            System.Console.WriteLine(found);
        }
    }
}