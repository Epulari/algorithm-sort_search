using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Search
{
    /*
     * 功能
     * 斐波那契查找
     * 根据斐波那契数列将序列分成两半，再依次将中间值及子序列与关键字对比
     * Epulari T 
     * 2018.8.17
     */
    class FibonacciSearch
    {
        /// <summary>
        /// 斐波那契查找-迭代法
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        /// <returns>key对应的原数组索引</returns>
        public int MyFibonacciSearch(int[] arr, int key)
        {
            int len = arr.Length;

            //根据数组长度创建斐波那契数列1,1,2,3,...(前面添加一个0不影响)
            List<int> fibonacci = new List<int>();
            int i = 0;
            fibonacci.Insert(i++, 0);
            fibonacci.Insert(i++, 1);
            for(i -= 1; fibonacci[i] <= len; i++)
            {
                fibonacci.Insert(i + 1, fibonacci[i] + fibonacci[i - 1]);
            }
            Console.Write("斐波那契数列：");
            foreach (int m in fibonacci)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            //根据斐波那契数列扩展数组
            int k = fibonacci.Count - 1, newlen = fibonacci[k] - 1;
            int[] newarr = new int[newlen];
            i = 0;
            while (i < len)
            {
                newarr[i] = arr[i++];
            }
            while(i < newlen)
            {
                newarr[i++] = arr[len - 1];
            }
            Console.Write("扩展后的数组：");
            foreach (int m in newarr)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            //查找
            int low = 0, high = newlen - 1, mid;
            while (low <= high && high < newlen)
            {
                mid = low + (fibonacci[k - 1] - 1);
                if (newarr[mid] == key)
                {
                    Console.WriteLine("mid-k：" + mid + "-" + k);
                    if (mid < newlen)
                    {
                        return mid;
                    }
                    else
                    {
                        //若mid>=len则说明是扩展的数值,返回n-1
                        return len - 1;
                    }
                }
                else if (newarr[mid] > key)
                {
                    //待查找的元素在[low,mid-1]范围内
                    high = mid - 1;
                    //范围[low,mid-1]内的元素个数为F(k-1)-1个，可以迭代地应用斐波那契查找
                    k -= 1;
                }
                else
                {
                    //待查找的元素在[mid+1,hign]范围内
                    low = mid + 1;
                    //范围[mid+1,high]内的元素个数为F(k-2)-1个，可以迭代地应用斐波那契查找
                    //元素个数计算：新数组长度- 左序列个数 - mid元素 = newlen -（F(k-1) - 1) - 1 = (F(k) - 1) - F(k-1) = F(k) - F(k-1) - 1=F(k-2) - 1
                    k -= 2;
                }
                Console.WriteLine("low-high-k：" + low + "-" + high + "-" + k);
            }
            return -1;
        }

        /// <summary>
        /// 斐波那契查找-递归法
        /// 递归函数：根据斐波那契数列进行分割
        /// </summary>
        /// <param name="arr">扩展后的数组</param>
        /// <param name="key">关键字</param>
        /// <param name="low">数组最小索引值</param>
        /// <param name="high">数组最大索引值</param>
        /// <param name="fibonacci">斐波那契数列链表</param>
        /// <param name="k">斐波那契数列索引</param>
        /// <param name="len">原数组长度</param>
        /// <returns>key对应的原数组索引</returns>
        private int FibonacciS(int[] arr, int key, int low, int high, List<int> fibonacci, int k, int len)
        {
            int newlen = arr.Length, mid;
            if(low <= high && high < newlen)
            {
                mid = low + (fibonacci[k - 1] - 1);
                if (arr[mid] == key)
                {
                    Console.WriteLine("mid-k：" + mid + "-" + k);
                    if (mid < newlen)
                    {
                        return mid;
                    }
                    else
                    {
                        //若mid>=len则说明是扩展的数值,返回n-1
                        return len - 1;
                    }
                }
                else if (arr[mid] > key)
                {
                    //待查找的元素在[low,mid-1]范围内
                    high = mid - 1;
                    //范围[low,mid-1]内的元素个数为F(k-1)-1个，可以迭代地应用斐波那契查找
                    k -= 1;
                    Console.WriteLine("low-high-k：" + low + "-" + high + "-" + k);
                    return FibonacciS(arr, key, low, high, fibonacci, k, len);
                }
                else
                {
                    //待查找的元素在[mid+1,hign]范围内
                    low = mid + 1;
                    //范围[mid+1,high]内的元素个数为F(k-2)-1个，可以迭代地应用斐波那契查找
                    //元素个数计算：新数组长度- 左序列个数 - mid元素 = newlen -（F(k-1) - 1) - 1 = (F(k) - 1) - F(k-1) = F(k) - F(k-1) - 1=F(k-2) - 1
                    k -= 2;
                    Console.WriteLine("low-high-k：" + low + "-" + high + "-" + k);
                    return FibonacciS(arr, key, low, high, fibonacci, k, len);
                }
            }
            return -1;
        }
        /// <summary>
        /// 斐波那契查找-递归法
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        /// <returns>key对应的原数组索引</returns>
        public int MyFibonacciSearch2(int[] arr, int key)
        {
            int len = arr.Length;

            //根据数组长度创建斐波那契数列1,1,2,3,...(前面添加一个0不影响)
            List<int> fibonacci = new List<int>();
            int i = 0;
            fibonacci.Insert(i++, 0);
            fibonacci.Insert(i++, 1);
            for (i -= 1; fibonacci[i] <= len; i++)
            {
                fibonacci.Insert(i + 1, fibonacci[i] + fibonacci[i - 1]);
            }
            Console.Write("斐波那契数列：");
            foreach (int m in fibonacci)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            //根据斐波那契数列扩展数组
            int k = fibonacci.Count - 1, newlen = fibonacci[k] - 1;
            int[] newarr = new int[newlen];
            i = 0;
            while (i < len)
            {
                newarr[i] = arr[i++];
            }
            while (i < newlen)
            {
                newarr[i++] = arr[len - 1];
            }
            Console.Write("扩展后的数组：");
            foreach (int m in newarr)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();

            //递归
            int index = FibonacciS(newarr, key, 0, newlen - 1, fibonacci, k, len);
            return index;
        }
    }
}
