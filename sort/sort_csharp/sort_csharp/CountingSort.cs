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
     * 2018.8.11
     */
    class CountingSort
    {
        /// <summary>
        /// 计数排序-计算数组中比元素i小的元素的个数x，那么我们就可以直接把i放到第（x+1）个位置，即i的索引为x（索引从0开始）
        /// </summary>
        /// <param name="arr">数组</param>
        public int[] MyCountingSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return arr;
            }
            
            //获取数组的最小值和最大值
            int max = arr[0];
            int min = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
                else if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("数组最小值：" + min);
            Console.WriteLine("数组最大值：" + max);

            //c[arr[i] - min]的索引arr[i] - min代表了arr[i]，因为每一个数字减去一定的数字值都是不一样的
            //即映射关系为f(x)=x-min，第一个桶即为最小值所在的桶，桶（数组）长度为k，减小了内存的占用
            //某值出现一次，则对应索引的值增加1
            //每个元素值对应c[]的索引，因此所有元素值就被排序了
            int k = max - min + 1;
            int[] temp = new int[k];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[arr[i] - min] += 1;
            }
            //输出本轮排序结果，字符以空格间隔
            Console.Write("每个元素个数统计：");
            foreach (int m in temp)
            {
                Console.Write(m + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();

            //计算每个元素值出现的次数与比它小的所有元素值出现的次数和
            for (int i = 1; i < k; i++)
            {
                temp[i] = temp[i] + temp[i - 1];
            }
            Console.Write("每个元素值及比它值小的所有元素的个数统计：");
            foreach (int m in temp)
            {
                Console.Write(m + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();

            //排序
            int[] newarr = new int[len];
            //倒序增加稳定性
            for (int i = len - 1; i >= 0; i--)
            {
                //c[arr[i] - min]的索引arr[i] - min代表了arr[i]，值代表了arr[i]出现的次数与比它小的所有元素值出现的次数和（可以认为其他与a[i]的值相等的元素a[j]也是小于a[i]的元素，这样便于理解）
                //因此比当前arr[i]小的元素的个数为这个和减去1，这个结果就是元素arr[i]的索引
                newarr[--temp[arr[i] - min]] = arr[i];
            }

            //输出本轮排序结果，字符以空格间隔
            foreach (int m in newarr)
            {
                Console.Write(m + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();

            return newarr;
        }

        /// <summary>
        /// 计数排序-依次输出：使用一个额外的数组，其中第i个元素是待排序数组中值等于i的元素的个数，据索引i的值依次在新数组中展开索引i
        /// </summary>
        /// <param name="arr">数组</param>
        public void MyCountingSort2(int[] arr)
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
