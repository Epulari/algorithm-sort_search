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
        /// <param name="key">关键字</param>
        /// <returns>key对应的原数组索引</returns>
        public int MySequenceSearch(int[] arr, int key)
        {
            int len = arr.Length;
            //索引一定不会为负
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                if(arr[i] == key)
                {
                    Console.WriteLine("比较第" + ++k + "次");
                    return i;
                }
                ++k;
            }
            Console.WriteLine("比较第" + k + "次");
            return -1;
        }
    }
}
