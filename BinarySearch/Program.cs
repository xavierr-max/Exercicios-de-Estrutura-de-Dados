using System;

namespace MyApp
{
    internal class Search
    {
        static void binarySearch(int[] A, int n , int key)
        {
            int l = 0;
            int r = n - 1;
            while(l <= r)
            {
                int mid = (r + l)/2;
                if(mid[A] == key)
                    return mid;
                if(mid[A] < key)
                    r = mid + 1
                if(mid[A] > key)
                    l = mid - 1
            }
            return -1;
        }
        
        static void Main(string[] args)
        {
           Search s = new Search();
           int[] a = {1, 23, 41, 50, 66, 78, 95}
           int found = s.binarySearch(a, 7, 50)
           System.Console.WriteLine(found);
        }
    }
}
