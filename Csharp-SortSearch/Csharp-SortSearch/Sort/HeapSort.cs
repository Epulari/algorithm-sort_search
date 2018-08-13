using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Sort
{
    /*
     * 功能
     * 堆排序
     * Epulari T 
     * 2018.8.7
     */
    class HeapSort
    {
        /// <summary>
        /// 堆排序
        /// </summary>
        /// <param name="arr">数组</param>
        public void MyHeapSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return;
            }
            int temp = 0;
            //外层循环：一轮比较。每次交换首尾元素值，只有1个元素时跳出循环
            for (int k = 0; k < len - 1; len--)
            {
                //内层循环：从下向上，从右至左调整位置，构建大顶堆。堆顶为最大值，最大的非叶子节点索引为len/2-1
                for (int i = len / 2 - 1; i > -1; i--)
                {
                    //节点i的左子节点2i+1和右子节点2i+2
                    int left = 2 * i + 1, right = 2 * i + 2;
                    //假设左右子节点大的值的索引maxindex为left，左节点一定存在
                    int maxindex = left;
                    //选择左右子节点中大的节点
                    if (right < len)
                    {
                        maxindex = arr[left] >= arr[right] ? left : right;
                    }
                    //判断父节点与子节点大小并交换
                    if (arr[maxindex] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[maxindex];
                        arr[maxindex] = temp;
                    }
                }
                //交换堆顶和堆尾元素
                temp = arr[0];
                arr[0] = arr[len - 1];
                arr[len - 1] = temp;

                //输出本轮排序结果，字符以空格间隔
                foreach (int m in arr)
                {
                    Console.Write(m + " ");
                }
                //换行，每轮为一行
                Console.WriteLine();
            }
        }
    }
}
