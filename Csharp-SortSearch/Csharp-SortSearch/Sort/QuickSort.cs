using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Sort
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
        /// 快速排序
        /// 确定关键值在数组中的位置，以此将数组划分成左右两区间，关键值游离在外
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="low">数组的起始位置</param>
        /// <param name="high">数组的终止位置</param>
        public int[] MyQuickSort(int[] arr, int low, int high)
        {
            int len = arr.Length;
            if (len < 2 || low >= high)
            {
                return arr;
            }
            //记录目标数组的起始位置（后续动态的左侧下标）/结束位置（后续动态的右侧下标）
            int first = low, last = high;
            //数组的第一个元素arr[low]作为关键值，所以元素arr[low]可以当作是一个空位，用于保存数据，之后每赋值一次，也会有一个位置空出来，直到last==first，此时arr[last]==arr[first]=key
            int key = arr[low];
            //外层循环：一轮比较，当（左侧动态下标 == 右侧动态下标） 时跳出循环
            while (first < last)
            {
                //右侧动态下标逐渐减小，直至找到小于或等于key值的下标，将该值赋值给空出来的位置，最开始关键值arr[low]的位置是空位
                while (first < last && arr[last] > key)
                {
                    last--;
                }
                arr[first] = arr[last];
                //左侧动态下标逐渐增加，直至找到大于key值的下标，将该值赋值给空出来的位置，空出来的位置是前面的结果
                while (first < last && arr[first] <= key)
                {
                    first++;
                }
                arr[last] = arr[first];
            }
            //将关键值赋值给空位
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
            return arr;
        }
    }
}
