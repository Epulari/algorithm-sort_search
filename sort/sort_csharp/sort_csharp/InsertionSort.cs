using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 插入排序
     * Epulari T 
     * 2018.8.2
     */
    public class InsertionSort
    {
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="arr">arr</param>
        public void MyInsertionSort(int[] arr)
        {
            //外层循环：一轮比较。每次已排序列多一个元素，i代表已排序列元素的最大索引，最开始只有一个元素arr[0]
            for (int i = 0, len = arr.Length; i < len - 1; i++)
            {
                //内层循环：进行每轮的单个元素比较。待排元素为已排元素的下一个值arr[i + 1]，即arr[j]，将之与已排元素进行比较
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        var temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        break;
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
