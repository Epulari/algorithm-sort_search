using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            
            //冒泡排序
            BubbleSort bs = new BubbleSort();
            bs.BulleSort(arr);
            /*result
                7 26 22 32 28 38 23 24 53 27 54 33 78
                7 22 26 28 32 23 24 38 27 53 33 54 78
                7 22 26 28 23 24 32 27 38 33 53 54 78
                7 22 26 23 24 28 27 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                程序的运行时间：0.0242318 秒
             */



            Console.ReadKey();
            
        }
    }
}
