using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Search
{
    /*
     * 功能
     * 顺序查找
     * 依次扫描每个元素并与关键字比较
     * Epulari T 
     * 2018.8.13
     */
    public class SequenceSearch
    {
        /// <summary>
        /// 顺序查找-不考虑重复
        /// </summary>
        /// <param name="arr">数组</param>
        public int MySequenceSearch(int[] arr, int key)
        {
            int len = arr.Length;
            for(int i = 0; i < len; i++)
            {
                if(arr[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
