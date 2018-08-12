using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 桶排序
     * 映射关系f(x)=Math.Sqrt(x);
     * Epulari T 
     * 2018.8.12
     */
    class BucketSort
    {
        /// <summary>
        /// 桶排序-映射关系f(x)=(int)Math.Sqrt(x)
        /// </summary>
        /// <param name="arr">数组</param>
        public void MyBucketSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return;
            }

            //设置映射关系为根号x：f(x) = Math.Sqrt(x)，并求出其中的最大最小值
            int[] reciprocal = new int[len];
            int min = arr[0], max = arr[0];
            for (int i = 0; i < len; i++)
            {
                reciprocal[i] = (int)Math.Sqrt(arr[i]);
                if (min > reciprocal[i])
                {
                    min = reciprocal[i];
                }
                else if (max < reciprocal[i])
                {
                    max = reciprocal[i];
                }
                else { }
            }
            //输出平方根结果，字符以空格间隔
            Console.Write("平方根：");
            foreach (int k in reciprocal)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
            //输出平方根最大最小值
            Console.WriteLine("数组最小值：" + min);
            Console.WriteLine("数组最大值：" + max);

            //设置桶的最大序号为max，则桶的数量为max+1，也可以设置桶的数量为max-min+1，则arr[max-i]可以代表arr[i]
            int tlen = max + 1;
            //每个桶也是一个数组
            //使用交叉数组定义，当后面出现桶的序号再实例化，而不是一开始用二维数组[10, len]定义，减少内存占用,且便于判断哪些桶内有数据
            int[][] temp = new int[tlen][];
            for (int i = 0; i < len; i++)
            {
                //根据映射关系找到桶下标，将对应的原数组值放入桶中
                int n = reciprocal[i];
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
            //依次输出桶内元素，字符以空格间隔
            Console.WriteLine("桶内元素：");
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

            //对桶内元素进行快排，并依次将桶内元素添加到新数组中（根据根号关系可以知道序号小的桶内元素一定小于序号大的桶内元素）
            int index = 0;
            QuickSort qs = new QuickSort();
            for (int i = 0; i < tlen; i++)
            {
                if (temp[i] != null)
                {
                    Console.WriteLine("第" + i + "个桶内快排：");
                    temp[i] = qs.MyQuickSort(temp[i], 0, len - 1);
                    
                    for(int j = 0; j < len; j++)
                    {
                        if(temp[i][j] != -1)
                        {
                            arr[index++] = temp[i][j];
                        }
                    }
                }
            }

            //输出排序结果，字符以空格间隔
            Console.Write("排序结果：");
            foreach (int k in arr)
            {
                Console.Write(k + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();
        }
    }
}