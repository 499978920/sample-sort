using System;
using System.Collections.Generic;

namespace sort
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    /// <remarks>
    /// 两两比较，前一个更大时交换位置，第一轮后最大的在最后；
    /// 再开启下一轮；
    /// 
    /// 时间复杂度 平均：O(n²)，最好：O(n)，最坏：O(n²)
    /// 稳定
    /// </remarks>
    public class BubbleSort : ISort
    {
        public void Sort(int[] src)
        {
            var arr = src.Clone() as int[];

            var swaped = true;
            var count = 0;

            for (int i = 0; i < arr.Length - 1 && swaped; i++)
            {
                swaped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;

                        swaped = true;
                    }
                    count++;
                }
            }

            Console.WriteLine("冒泡排序：");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}