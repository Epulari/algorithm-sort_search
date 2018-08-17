using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_SortSearch.Sort;
using Csharp_SortSearch.Search;

namespace Csharp_SortSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_bs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            BubbleSort bs = new BubbleSort();
            Console.WriteLine("冒泡排序：");
            bs.MyBulleSort(arr_bs);
            /*result
                7 26 22 32 28 38 23 24 53 27 54 33 78
                7 22 26 28 32 23 24 38 27 53 33 54 78
                7 22 26 28 23 24 32 27 38 33 53 54 78
                7 22 26 23 24 28 27 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                程序的运行时间：0.0242318 秒
             */

            int[] arr_qs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            QuickSort qs = new QuickSort();
            Console.WriteLine("快速排序：");
            qs.MyQuickSort(arr_qs, 0, arr_qs.Length - 1);
            /*result
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 24 23 22 26 28 38 32 53 54 27 78 33
                7 22 23 24 26 28 38 32 53 54 27 78 33
                7 22 23 24 26 28 38 32 53 54 27 78 33
                7 22 23 24 26 27 28 32 53 54 38 78 33
                7 22 23 24 26 27 28 32 53 54 38 78 33
                7 22 23 24 26 27 28 32 33 38 53 78 54
                7 22 23 24 26 27 28 32 33 38 53 78 54
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_ins = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            InsertionSort ins = new InsertionSort();
            Console.WriteLine("插入排序：");
            ins.MyInsertionSort(arr_ins);
            /*result
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 22 26 53 32 28 38 23 24 54 27 78 33
                7 22 26 32 53 28 38 23 24 54 27 78 33
                7 22 26 28 32 53 38 23 24 54 27 78 33
                7 22 26 28 32 38 53 23 24 54 27 78 33
                7 22 23 26 28 32 38 53 24 54 27 78 33
                7 22 23 24 26 28 32 38 53 54 27 78 33
                7 22 23 24 26 28 32 38 53 54 27 78 33
                7 22 23 24 26 27 28 32 38 53 54 78 33
                7 22 23 24 26 27 28 32 38 53 54 78 33
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_shs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            ShellSort shs = new ShellSort();
            Console.WriteLine("希尔排序：");
            shs.MyShellSort(arr_shs);
            /*result
                gap=13
                本轮结果：
                7 26 53 22 32 28 38 23 24 54 27 78 33
                gap=4
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 26 38 22 32 28 53 23 24 54 27 78 33
                7 26 38 22 32 28 53 23 24 54 27 78 33
                7 26 38 22 24 28 53 23 32 54 27 78 33
                7 26 38 22 24 28 53 23 32 54 27 78 33
                7 26 27 22 24 28 38 23 32 54 53 78 33
                7 26 27 22 24 28 38 23 32 54 53 78 33
                7 26 27 22 24 28 38 23 32 54 53 78 33
                本轮结果：
                7 26 27 22 24 28 38 23 32 54 53 78 33
                gap=1
                7 26 27 22 24 28 38 23 32 54 53 78 33
                7 26 27 22 24 28 38 23 32 54 53 78 33
                7 22 26 27 24 28 38 23 32 54 53 78 33
                7 22 24 26 27 28 38 23 32 54 53 78 33
                7 22 24 26 27 28 38 23 32 54 53 78 33
                7 22 24 26 27 28 38 23 32 54 53 78 33
                7 22 23 24 26 27 28 38 32 54 53 78 33
                7 22 23 24 26 27 28 32 38 54 53 78 33
                7 22 23 24 26 27 28 32 38 54 53 78 33
                7 22 23 24 26 27 28 32 38 53 54 78 33
                7 22 23 24 26 27 28 32 38 53 54 78 33
                7 22 23 24 26 27 28 32 33 38 53 54 78
                本轮结果：
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_ses = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            SelectionSort ses = new SelectionSort();
            Console.WriteLine("选择排序：");
            ses.MySelectionSort(arr_ses);
            /*result
                7 26 53 22 32 28 38 23 24 54 27 78 33
                7 22 53 26 32 28 38 23 24 54 27 78 33
                7 22 23 53 32 28 38 26 24 54 27 78 33
                7 22 23 24 53 32 38 28 26 54 27 78 33
                7 22 23 24 26 53 38 32 28 54 27 78 33
                7 22 23 24 26 27 53 38 32 54 28 78 33
                7 22 23 24 26 27 28 53 38 54 32 78 33
                7 22 23 24 26 27 28 32 53 54 38 78 33
                7 22 23 24 26 27 28 32 33 54 53 78 38
                7 22 23 24 26 27 28 32 33 38 54 78 53
                7 22 23 24 26 27 28 32 33 38 53 78 54
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_hs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            HeapSort hs = new HeapSort();
            Console.WriteLine("堆排序：");
            hs.MyHeapSort(arr_hs);
            /*result
                33 54 7 24 26 53 38 23 22 32 27 28 78
                28 33 53 24 32 7 38 23 22 26 27 54 78
                27 33 28 24 32 7 38 23 22 26 53 54 78
                26 33 27 24 32 7 28 23 22 38 53 54 78
                22 26 28 24 32 7 27 23 33 38 53 54 78
                23 22 28 24 26 7 27 32 33 38 53 54 78
                27 26 23 24 22 7 28 32 33 38 53 54 78
                7 26 23 24 22 27 28 32 33 38 53 54 78
                22 7 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_ms = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            MergeSort ms = new MergeSort();
            Console.WriteLine("归并排序：");
            ms.MyMergeSort(arr_ms);
            /*result
                26 53
                7 26 53
                28 32
                22 28 32
                7 22 26 28 32 53
                23 24
                23 24 38
                27 54
                33 78
                27 33 54 78
                23 24 27 33 38 54 78
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_cs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            CountingSort cs = new CountingSort();
            Console.WriteLine("计数排序1：");
            cs.MyCountingSort(arr_cs);
            /*result
                数组最小值：7
                数组最大值：78
                每个元素个数统计：1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 1 0 1 1 1 0 0 0 1 1 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1
                每个元素值及比它值小的所有元素的个数统计：1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 2 3 4 4 5 6 7 7 7 7 8 9 9 9 9 9 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 11 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 12 13
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */
            int[] arr_cs2 = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            Console.WriteLine("计数排序2：");
            cs.MyCountingSort2(arr_cs2);
            /*result
                数组最小值：7
                数组最大值：78
                每个元素个数统计：0 0 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 1 0 1 1 1 0 0 0 1 1 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1
                7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_bus = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            BucketSort bus = new BucketSort();
            Console.WriteLine("桶排序：");
            bus.MyBucketSort(arr_bus);
            /*result
                平方根：2 5 7 4 5 5 6 4 4 7 5 8 5
                数组最小值：2
                数组最大值：8
                桶内元素：
                7 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                22 23 24 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                26 32 28 27 33 -1 -1 -1 -1 -1 -1 -1 -1
                38 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                53 54 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                78 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                第2个桶内快排：-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 7
                第4个桶内快排：-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 22 23 24
                第5个桶内快排：-1 -1 -1 -1 -1 -1 -1 -1 26 27 28 32 33
                第6个桶内快排：-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 38
                第7个桶内快排：-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 53 54
                第8个桶内快排：-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 78
                排序结果：7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            int[] arr_rs = { 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 };
            RadixSort rs = new RadixSort();
            Console.WriteLine("基数排序：");
            rs.MyRadixSort(arr_rs);
            /*result
                桶内：22 32 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                53 23 33 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                24 54 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                26 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                7 27 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                28 38 78 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                桶外：22 32 53 23 33 24 54 26 7 27 28 38 78
                桶内：7 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                22 23 24 26 27 28 -1 -1 -1 -1 -1 -1 -1
                32 33 38 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                53 54 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                78 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1
                桶外：7 22 23 24 26 27 28 32 33 38 53 54 78
             */

            Console.WriteLine("");
            Console.WriteLine("");
            int[] arr_s = { 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 };
            int index;

            SequenceSearch ss = new SequenceSearch();
            Console.WriteLine("顺序查找：");
            index = ss.MySequenceSearch(arr_s, 53);
            Console.WriteLine("查找成功： " + index);
            index = ss.MySequenceSearch(arr_s, 52);
            Console.WriteLine("查找失败： " + index);
            /*result
                比较第11次
                查找成功： 10
                比较第13次
                查找失败： -1
             */

            BinarySearch bis = new BinarySearch();
            Console.WriteLine("二分查找1：");
            index = bis.MyBinarySearch(arr_s, 53);
            Console.WriteLine("查找成功： " + index);
            index = bis.MyBinarySearch(arr_s, 52);
            Console.WriteLine("查找失败： " + index);
            Console.WriteLine("二分查找2：");
            index = bis.MyBinarySearch2(arr_s, 53, 0, arr_s.Length - 1);
            Console.WriteLine("查找成功： " + index);
            index = bis.MyBinarySearch2(arr_s, 52, 0, arr_s.Length - 1);
            Console.WriteLine("查找失败： " + index);
            /*result
                low-high：7-12
                low-high：10-12
                low-high：10-10
                mid：10
                查找成功： 10
                low-high：7-12
                low-high：10-12
                low-high：10-10
                low-high：10-9
                查找失败： -1
             */

            InterpolationSearch ints = new InterpolationSearch();
            Console.WriteLine("插值查找1：");
            index = ints.MyInterpolationSearch(arr_s, 53);
            Console.WriteLine("查找成功： " + index);
            index = ints.MyInterpolationSearch(arr_s, 52);
            Console.WriteLine("查找失败： " + index);
            index = ints.MyInterpolationSearch2(arr_s, 53, 0, arr_s.Length - 1);
            Console.WriteLine("查找成功： " + index);
            index = ints.MyInterpolationSearch2(arr_s, 52, 0, arr_s.Length - 1);
            Console.WriteLine("查找失败： " + index);
            /*result
                low-high：8-12
                low-high：10-12
                mid：10
                查找成功： 10
                low-high：8-12
                low-high：10-12
                low-high：10-9
                查找失败： -1
             */

            FibonacciSearch fs = new FibonacciSearch();
            Console.WriteLine("斐波那契查找1：");
            index = fs.MyFibonacciSearch(arr_s, 53);
            Console.WriteLine("查找成功： " + index);
            index = fs.MyFibonacciSearch(arr_s, 52);
            Console.WriteLine("查找失败： " + index);
            Console.WriteLine("斐波那契查找2：");
            index = fs.MyFibonacciSearch2(arr_s, 53);
            Console.WriteLine("查找成功： " + index);
            index = fs.MyFibonacciSearch(arr_s, 52);
            Console.WriteLine("查找失败： " + index);
            /*result
                斐波那契数列：0 1 1 2 3 5 8 13 21
                扩展后的数组：7 22 23 24 26 27 28 32 33 38 53 54 78 78 78 78 78 78 78 78
                low-high-k：0-11-7
                low-high-k：8-11-5
                mid-k：10-5
                查找成功： 10
                斐波那契数列：0 1 1 2 3 5 8 13 21
                扩展后的数组：7 22 23 24 26 27 28 32 33 38 53 54 78 78 78 78 78 78 78 78
                low-high-k：0-11-7
                low-high-k：8-11-5
                low-high-k：8-9-4
                low-high-k：10-9-2
                查找失败： -1
             */

            BlockSearch bls = new BlockSearch();
            Console.WriteLine("分块查找：");
            index = bls.MyBlockSearch(arr_s, 53, 4);
            Console.WriteLine("查找成功： " + index);
            index = bls.MyBlockSearch(arr_s, 52, 4);
            Console.WriteLine("查找失败： " + index);
            /*result
                序列数组：
                7 22 23 24
                26 27 28 32
                33 38 53 54
                78
                最小值最大值：
                7 26 33 78 24 32 54 78
                low-high：2-3
                mid：2
                查找成功： 10

                序列数组：
                7 22 23 24
                26 27 28 32
                33 38 53 54
                78
                最小值最大值：
                7 26 33 78 24 32 54 78
                low-high：2-3
                low-high：2-1
                查找失败： -1
             */

            int[] arr_bts = { 32, 24, 54, 22, 27, 38, 78, 7, 23, 26, 28, 33, 53 };
            BinaryTreeSearch bts = new BinaryTreeSearch();
            Console.WriteLine("二叉树查找1：");
            index = bts.MyBinaryTreeSearch(arr_bts, 53);
            Console.WriteLine("查找成功： " + index);
            index = bts.MyBinaryTreeSearch(arr_bts, 52);
            Console.WriteLine("查找失败： " + index);
            Console.WriteLine("二叉树查找2：");
            index = bts.MyBinaryTreeSearch2(arr_bts, 53, 0, 0);
            Console.WriteLine("查找成功： " + index);
            index = bts.MyBinaryTreeSearch2(arr_bts, 52, 0, 0);
            Console.WriteLine("查找失败： " + index);
            /*result
                第1次比较：i-0 arr[i]-32
                第2次比较：i-2 arr[i]-54
                第3次比较：i-5 arr[i]-38
                第4次比较：i-12 arr[i]-53
                查找成功： 12
                第1次比较：i-0 arr[i]-32
                第2次比较：i-2 arr[i]-54
                第3次比较：i-5 arr[i]-38
                第4次比较：i-12 arr[i]-53
                查找失败： -1
             */

            Console.ReadKey();
        }
    }
}
