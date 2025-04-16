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
            Search s = new Search();
            int[] a = {5, 32, 56, 76, 97};
            int found = LinearSearch(a, 5, 76);
            System.Console.WriteLine(found);

        }
    }
}