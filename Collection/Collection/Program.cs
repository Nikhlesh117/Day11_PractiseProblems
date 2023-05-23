using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] chapters = new int[][]
        {
            new int[] { 1, 4 },
            new int[] { 5, 7 },
            new int[] { 9, 16 },
            new int[] { 17, 26 }
        };  // Start and end page of each chapter

            int currentPage = 7;  // Current reading page

            Book book = new Book(chapters);
            int remainingChapters = book.CountRemainingChapters(currentPage);
            Console.WriteLine("Remaining Chapter : " + remainingChapters);

            Console.ReadLine();
        }
    }
}
