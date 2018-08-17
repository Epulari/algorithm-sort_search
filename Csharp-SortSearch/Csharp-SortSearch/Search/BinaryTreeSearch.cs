using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_SortSearch.Search
{
    /*
     * 功能
     * 二叉树查找
     * 构建二叉查找树，左子树小于根节点，右子树大于根节点，依次比较
     * Epulari T 
     * 2018.8.14
     */
    public class BinaryTreeSearch
    {
        /// <summary>
        /// 二叉树查找-迭代法:数组已构成二叉查找树
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        /// <returns>key对应的原数组索引</returns>
        public int MyBinaryTreeSearch(int[] arr, int key)
        {
            int len = arr.Length;

            //i为二叉树父节点索引，k为比较次数
            int i = 0, k = 0;
            while(i < len)
            {
                Console.WriteLine("第" + ++k + "次比较：i-" + i + " arr[i]-" + arr[i]);
                if (arr[i] == key)
                {
                    return i;
                }
                else if (arr[i] > key)
                {
                    //左子节点
                    i = 2 * i + 1;
                }
                else
                {
                    //右子节点
                    i = 2 * i + 2;
                }
            }
            return -1;
        }

        /// <summary>
        /// 二叉树查找-递归法:数组已构成二叉查找树
        /// </summary>
        /// <param name="arr">数组</param>
        /// <param name="key">关键字</param>
        /// <param name="i">二叉树父节点索引</param>
        /// <param name="k">比较次数</param>
        /// <returns>key对应的原数组索引</returns>
        public int MyBinaryTreeSearch2(int[] arr, int key, int i, int k)
        {
            int len = arr.Length;
            
            while (i < len)
            {
                Console.WriteLine("第" + ++k + "次比较：i-" + i + " arr[i]-" + arr[i]);
                if (arr[i] == key)
                {
                    return i;
                }
                else if (arr[i] > key)
                {
                    //左子节点
                    return MyBinaryTreeSearch2(arr, key, 2 * i + 1, k);
                }
                else
                {
                    //右子节点
                    return MyBinaryTreeSearch2(arr, key, 2 * i + 2, k);
                }
            }
            return -1;
        }
    }
}
