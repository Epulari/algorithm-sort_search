using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 计数排序
     * Epulari T 
     * 2018.8.9
     */
    class CountingSort
    {        
        /// <summary>
        /// 计数排序
        /// </summary>
        /// <param name="arr">数组</param>
        public void MyCountingSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return;
            }

            //获取数组的最小值和最大值
            int min = arr[0], max = arr[0];
            for (int i = 1; i < len; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                else if (max < arr[i])
                {
                    max = arr[i];
                }
                else { }
            }
            Console.WriteLine("数组最小值：" + min);
            Console.WriteLine("数组最大值：" + max);

            //根据最大值max初始化额外数组，数组最大索引值为max，则数组长度为max+1
            int templen = max + 1;
            int[] temp = new int[templen];
            for (int i = 0; i < templen; i++)
            {
                temp[i] = 0;
            }

            //统计数组每个数的个数
            for (var i = 0; i < len; i++)
            {
                var index = arr[i];
                temp[index] += 1;
            }
            //输出本轮排序结果，字符以空格间隔
            Console.Write("每个元素个数统计：");
            foreach (int k in temp)
            {
                Console.Write(k + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();

            //根据索引i的值依次在新数组中展开索引i
            int[] newarr = new int[len];
            for(int i = 0, j = 0; i < templen; i++)
            {
                while (temp[i] != 0)
                {
                    newarr[j++] = i;
                    temp[i] -= 1;
                }
            }
            //输出本轮排序结果，字符以空格间隔
            foreach (int k in newarr)
            {
                Console.Write(k + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();
        }
    }
}
