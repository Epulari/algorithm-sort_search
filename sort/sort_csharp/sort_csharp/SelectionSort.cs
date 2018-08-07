using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 选择排序
     * Epulari T 
     * 2018.8.7
     */
    class SelectionSort
    {
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="arr">数组</param>
        public void MySelectionSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return;
            }
            for (var i = 0; i < len - 1; i++)
            {
                //内层循环：依次与待比较元素的值比较并交换
                for (var j = i + 1; j < len; j++)
                {
                    int temp = arr[i];
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
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
        }
    }
}
