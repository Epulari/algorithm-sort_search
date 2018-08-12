using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 基数排序
     * 对数字进行排序，不考虑负数，不考虑小数点
     * Epulari T 
     * 2018.8.10
     */
    class RadixSort
    {
        /// <summary>
        /// 放入桶内和放回数组
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="len">数组长度</param>
        /// <param name="digit">求位数时的变量</param>
        /// <returns>一次排序后的数组</returns>
        int[] RadixInOut(int[] arr, int len, int digit)
        {
            //定义十个桶，每个桶也是一个数组，
            //使用交叉数组定义，当后面出现桶的序号再实例化，而不是一开始用二维数组[10, len]定义，减少内存占用
            int[][] temp = new int[10][];

            //将arr中的元素值依次放入对应桶中
            for (int i = 0; i < len; i++)
            {
                //个位数：a/1%10；十位数：a/10%10；百位数：a/100%10……则中间的digit=10^n决定取哪一位
                int n = (int)(arr[i] / digit % 10);
                //将arr[i]放入对应的空桶temp[n]中
                //第一次出现某个位数值，实例化空桶temp[n]，并将arr[i]放入空桶
                if (temp[n] == null)
                {
                    //不知道到底该位数值有多少个，因此长度设置为原数组长度
                    temp[n] = new int[len];
                    //初始化数组值为一定不存在的值
                    for (int j = 0; j < len; j++)
                    {
                        temp[n][j] = -1;
                    }
                    temp[n][0] = arr[i];
                }
                else
                {
                    //temp[n]已存在时循环temp[n]，找到值不为-1的索引，将arr[i]放入对应位置
                    int j = 0;
                    while (temp[n][j] != -1)
                    {
                        j++;
                    }
                    temp[n][j] = arr[i];
                }
            }
            //依次打印出桶内元素，字符以空格间隔
            Console.Write("桶内：");
            foreach (int[] m in temp)
            {
                if (m != null)
                {
                    foreach (int k in m)
                    {
                        Console.Write(k + " ");
                    }
                    //换行，每个桶为一行
                    Console.WriteLine();
                }
            }

            //将桶内元素依次放回到数组中
            for (int i = 0, k = 0; i < 10; i++)
            {
                if (temp[i] != null)
                {
                    int j = 0;
                    while (temp[i][j] != -1)
                    {
                        arr[k++] = temp[i][j++];
                    }
                }
            }
            //依次打印出数组元素
            Console.Write("桶外：");
            foreach (int k in arr)
            {
                Console.Write(k + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();

            return arr;
        }

        /// <summary>
        /// 基数排序
        /// </summary>
        /// <param name="arr">数组</param>
        public void MyRadixSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return;
            }

            //获取数组中最大的位数
            int digit = 0;
            for (int i = 0; i < len; i++)
            {
                int this_digit = ((int)arr[i]).ToString().Length;
                if (this_digit > digit)
                {
                    digit = this_digit;
                }
            }

            //依次进行个位排序，十位排序，……
            for (int i = 0; i < digit; i++)
            {
                //个位数：a/1%10；十位数：a/10%10；百位数：a/100%10……则中间的10的n次方决定取哪一位
                int cal_digit = (int)Math.Pow(10, i);
                arr = RadixInOut(arr, len, cal_digit);
            }
        }
    }
}
