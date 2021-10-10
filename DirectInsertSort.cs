using System;

namespace sort
{
    /// <summary>
    /// 直接插入排序
    /// 把数组成两个序列，前面的序列有序，后面的序列无序，
    /// 循环取无序序列第一个，插入到前面合适的有序序列位置
    /// 
    /// 平均：O(n²)，最佳：O(n)，最坏；O(n²)
    /// 稳定
    /// </summary>
    public class DirectInsertSort : ISort
    {
        // public void Sort(int[] src)
        // {
        //     var arr = src.Clone() as int[];

        //     for (var i = 1; i < arr.Length; i++)
        //     {
        //         var temp = arr[i];
        //         var j = i - 1;

        //         // 移动元素，给小的挪位置
        //         while (j >= 0 && temp < arr[j])
        //         {
        //             arr[j + 1] = arr[j];
        //             j--;
        //         }

        //         // 这时的 j 经过上面的 --，则表示 j+1 是插入的位置
        //         arr[j + 1] = temp;
        //     }

        //     Console.WriteLine("直接插入排序：");
        //     Console.WriteLine(string.Join(" ", arr));
        // }

        public void Sort(int[] src)
        {
            var arr = src.Clone() as int[];

            for (var i = 1; i < arr.Length; i++)
            {
                var j = i;

                // 移动元素，给小的挪位置
                // 交换法
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    var t = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = t;
                    j--;
                }
            }

            Console.WriteLine("直接插入排序：");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}