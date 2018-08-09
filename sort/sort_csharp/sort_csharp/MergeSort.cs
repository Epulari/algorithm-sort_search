using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_csharp
{
    /*
     * 功能
     * 归并排序
     * Epulari T 
     * 2018.8.9
     */
    class MergeSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left">左数组</param>
        /// <param name="right">右数组</param>
        /// <returns>排序好的数组</returns>
        int[] MergeArray(int[] left, int[] right)
        {
            int llen = left.Length;
            int rlen = right.Length;
            int[] arr = new int[llen + rlen];
            //两数组都有元素时
            int i = 0, j = 0, k = 0;
            while (i < llen && j < rlen)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }
            //合并后的序列为arr与剩下的左数组或右数组的结合
            if(i < llen)
            {
                for(; i < llen;)
                {
                    arr[k++] = left[i++];
                }
            }
            else if(j < rlen)
            {
                for (; j < rlen;)
                {
                    arr[k++] = right[j++];
                }
            }
            else
            { }

            //输出当前有序序列
            foreach (int m in arr)
            {
                Console.Write(m + " ");
            }
            //换行，每轮为一行
            Console.WriteLine();

            return arr;
        }

        /// <summary>
        /// 归并排序-递归方法
        /// </summary>
        /// <param name="arr">数组</param>
        /// <returns>排序好的数组</returns>
        public int[] MyMergeSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return arr;
            }

            //选取中间元素为基准元素
            int mid = len / 2;
            int[] left = new int[mid], right = new int[len - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
                right[i] = arr[mid + i];
            }
            if(mid < len - mid)
            {
                right[len - mid - 1] = arr[len - 1];
            }
            
            return MergeArray(MyMergeSort(left), MyMergeSort(right)); //递归            
        }
    }
}
