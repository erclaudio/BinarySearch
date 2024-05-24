using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 3453, 3533, 22, 441, 1111 };
            int len = n.Length;

            int key = int.Parse(Console.ReadLine());
            int left = 0;
            int right = len-1;
            int mid = 0;

            int pos = -1;

            while (left <= right && pos ==-1)
            {
                mid = (left + right) / 2;
                if (n[mid] == key)                
                    pos = mid;                
                else if (n[mid] > key)
                    right = mid - 1;
                else 
                    left = mid + 1;
                
            }
            if (pos != -1)
            {
                Console.WriteLine($"La chiave {key} è stata trovata in posizione {pos}");
            }
            else
                Console.WriteLine($"Non trovato");



        }
    }
}
