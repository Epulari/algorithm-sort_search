﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Sort
{
    /*
     * 功能
     * 冒泡排序
     * 比较相邻的两个数，如果前者比后者大，则进行交换，每一轮排序后最后一个元素必然是最大的数
     * Epulari T 
     * 2018.7.31
     */
    public class BubbleSort
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="arr">数组</param>
        public void MyBulleSort(int[] arr)
        {
            int len = arr.Length;
            if (len < 2)
            {
                return;
            }
            //外层循环：一轮比较。每次都从第一个元素开始，但是每次最后都减少一个元素，则相当于每次len-1
            for (int i = 0; i < len - 1; len--)
            {
                //内层循环：相邻元素两两对比
                for (int j = 0; j < len - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                //输出本轮排序结果，字符以空格间隔
                foreach (int k in arr)
                {
                    Console.Write(k + " ");
                }
                //换行，每轮为一行
                Console.WriteLine();
            }
        }
    }
}
