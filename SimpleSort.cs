using System;

namespace sort
{
    /// <summary>
    /// 简单排序
    /// 每次从未排序的里面选取最小的数，交换后，放到前面有序位
    /// 时间复杂度 O(n²)
    /// 不稳定
    /// </summary>
    public class SimpleSort : ISort
    {
        public void Sort(int[] src)
        {
            var arr = src.Clone() as int[];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                var minIndex = i;

                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    var t = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = t;
                }
            }

            Console.WriteLine("简单排序：");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}