using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Search
{
    /*
     * 功能
     * 插值查找
     * 改进的折半查找，mid计算方式不同
     * Epulari T 
     * 2018.8.14
     */
    class InterpolationSearch
    {
        /// <summary>
        /// 插值查找-迭代法
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        public int MyInterpolationSearch(int[] arr, int key)
        {
            int len = arr.Length;
            int low = 0, high = len - 1, mid;
            while (low <= high && high < len)
            {
                //使用复杂的四则运算定义中间值索引
                mid = low + (high - low) * (key - arr[low]) / (arr[high] - arr[low]);
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
        /// 插值查找-递归法
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        /// <param name="low">数组最小索引值</param>
        /// <param name="high">数组最大索引值</param>
        public int MyInterpolationSearch2(int[] arr, int key, int low, int high)
        {
            int len = arr.Length;
            if (low <= high && high < len)
            {
                //使用复杂的四则运算定义中间值索引
                var mid = low + (high - low) * (key - arr[low]) / (arr[high] - arr[low]);
                if (arr[mid] == key)
                {
                    Console.WriteLine("mid：" + mid);
                    return mid;
                }
                else if (arr[mid] > key)
                {
                    high = mid - 1;
                    Console.WriteLine("low-high：" + low + "-" + high);
                    return MyInterpolationSearch2(arr, key, low, high);
                }
                else
                {
                    low = mid + 1;
                    Console.WriteLine("low-high：" + low + "-" + high);
                    return MyInterpolationSearch2(arr, key, low, high);
                }
            }
            return -1;
        }
    }
}
