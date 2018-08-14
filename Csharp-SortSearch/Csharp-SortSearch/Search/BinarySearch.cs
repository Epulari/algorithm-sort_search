using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Search
{
    /*
     * 功能
     * 二分查找
     * 根据首尾元素的索引值将序列分成两半，再依次将中间值及子序列与关键字对比
     * Epulari T 
     * 2018.8.14
     */
    class BinarySearch
    {
        /// <summary>
        /// 二分查找-迭代法
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        public int MyBinarySearch(int[] arr, int key)
        {
            int len = arr.Length;
            int low = 0, high = len - 1, mid;
            while (low <= high && high < len)
            {
                //中间元素为首元素索引与尾元素索引和的平均值
                //为了防止溢出，使用位运算(right - left) >> 1替代(low + high) / 2，又使用(right - left) >>> 1替代(right - left) >> 1
                mid = (low + high) / 2;
                if (arr[mid] == key)
                {
                    Console.WriteLine("mid：" + mid);
                    return mid;
                }
                else if (arr[mid] > key)
                {
                    high = mid - 1;
                    Console.WriteLine("low-high：" + low + "-" + high);
                }
                else
                {
                    low = mid + 1;
                    Console.WriteLine("low-high：" + low + "-" + high);
                }
            }
            return -1;
        }

        /// <summary>
        /// 二分查找-递归法
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        /// <param name="low">数组最小索引值</param>
        /// <param name="high">数组最大索引值</param>
        public int MyBinarySearch2(int[] arr, int key, int low, int high)
        {
            int len = arr.Length;
            if (low <= high && high < len)
            {
                //中间元素为首元素索引与尾元素索引和的平均值
                //为了防止溢出，使用位运算(right - left) >> 1替代(low + high) / 2，又使用(right - left) >>> 1替代(right - left) >> 1
                var mid = (low + high) / 2;
                if (arr[mid] == key)
                {
                    Console.WriteLine("mid：" + mid);
                    return mid;
                }
                else if (arr[mid] > key)
                {
                    high = mid - 1;
                    Console.WriteLine("low-high：" + low + "-" + high);
                    return MyBinarySearch2(arr, key, low, high);
                 }
                else
                {
                    low = mid + 1;
                    Console.WriteLine("low-high：" + low + "-" + high);
                    return MyBinarySearch2(arr, key, low, high);
                }
            }
            return -1;
        }
    }
}
