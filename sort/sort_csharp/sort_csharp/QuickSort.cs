using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 快速排序
     * Epulari T 
     * 2018.8.2
     */
    class QuickSort
    {
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="arr">arr</param>
        /// <param name="low">arr</param>
        /// <param name="high">arr</param>
        public void MyQuickSort(int[] arr, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int first = low, last = high;
            //此时arr[low]被保存到key，所以元素arr[low]可以当作是一个空位，用于保存数据，之后每赋值一次，也会有一个位置空出来，直到last==first，此时arr[last]==arr[first]=key
            int key = arr[low];
            while (first < last)
            {
                while (first < last && arr[last] >= key)
                {
                    last--;
                }
                arr[first] = arr[last];
                while (first < last && arr[first] <= key)
                {
                    first++;
                }
                arr[last] = arr[first];
            }
            arr[first] = key;

            //输出本轮排序结果，字符以空格间隔
            foreach (int k in arr)
            {
                Console.Write(k + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();

            //递归排序数组左边的元素
            MyQuickSort(arr, low, first - 1);
            //递归排序右边的元素
            MyQuickSort(arr, first + 1, high);
        }
    }
}
