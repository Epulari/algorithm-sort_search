using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 希尔排序
     * Epulari T 
     * 2018.8.6
     */
    class ShellSort
    {
        /// <summary>
        /// 希尔排序
        /// </summary>
        /// <param name="arr">数组</param>
        public void MyShellSort(int[] arr)
        {
            int len = len = arr.Length;
            if (len < 2)
            {
                return;
            }
            //间隔（步长）的值，取值方法之一：gap = 3 * gap + 1;
            int gap = 1;
            while (gap < len)
            {
                gap = 3 * gap + 1;
            }
            if (gap >= len)
            {
                gap = (gap - 1) / 3;
            }
            //步长为1时执行一次插入排序，然后结束排序
            while (gap > 0)
            {
                //外层循环：一轮比较。每次已排序列多一个元素，i代表已排序列元素的最大索引，最开始只有一个元素arr[0]
                Console.WriteLine("gap=" + gap);
                for (int i = gap; i < len; i++)
                {
                    //待排元素
                    int current = arr[i];
                    //j为已排元素，最大取值为待排元素上一位
                    int j = i - gap;
                    //内层循环：进行每轮的单个元素比较。待排元素为已排元素的下一个值arr[i + 1]，即arr[j]，将之与已排元素进行比较并向后移位
                    while (j >= 0 && current < arr[j])
                    {
                        arr[j + gap] = arr[j];
                        j -= gap;
                    }
                    //当不进入while循环内部时，避免同一个元素赋值给自身
                    if (j + gap != i)
                    {
                        arr[j + gap] = current;
                    }
                    foreach (int k in arr)
                    {
                        Console.Write(k + " ");
                    }
                    //换行，每轮为一行
                    Console.WriteLine();
                }

                Console.WriteLine("本轮结果：");
                foreach (int k in arr)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();

                gap = (gap - 1) / 3;
            }
        }
    }
}
