using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //定义计时对象

namespace sort_csharp
{
    public class BubbleSort
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr">arr</param>
        public void BulleSort(int[] arr)
        {
            Stopwatch oTime = new Stopwatch(); //定义一个计时对象
            oTime.Start(); //开始计时 

            //外层循环：一轮比较。每次都从第一个元素开始，但是每次最后都减少一个元素，则相当于每次len-1
            for (int i = 0, len = arr.Length; i < len - 1; len--)
            {
                //内层循环：相邻元素两两对比
                for (int j = 0; j < len - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                //输出本轮排序结果，字符以空格间隔
                foreach (int k in arr)
                {
                    Console.Write(k + " ");
                }
                //换行，每轮为一行
                Console.WriteLine();
            }

            oTime.Stop(); //结束计时
            Console.WriteLine("程序的运行时间：{0} 秒", oTime.Elapsed.TotalSeconds);
        }
    }
}
