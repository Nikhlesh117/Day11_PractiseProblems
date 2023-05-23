using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Book
    {
        private int[][] chapters;
        private int totalChapters;

        public Book(int[][] chapters)
        {
            this.chapters = chapters;
            this.totalChapters = chapters.Length;
        }

        public int CountRemainingChapters(int currentPage)
        {
            int remainingChapters = 0;

            for (int i = 0; i < totalChapters; i++)
            {
                int startPage = chapters[i][0];
                int endPage = chapters[i][1];

                if (currentPage >= startPage && currentPage <= endPage)
                {
                    remainingChapters = totalChapters - i;
                    break;
                }
            }

            return remainingChapters;
        }
    }
}
