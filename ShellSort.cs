using System;

namespace sort
{
    /// <summary>
    /// 希尔排序
    /// 分组后做直接插入排序，
    /// 分组可以理解为进步，直接插入排序每次进步为1
    /// 希尔排序进步可变，第一次为数组的一半，第二次一半的一半，以此类推
    /// 进步不一定为数组的一半，可以设定
    /// 
    /// 最坏：O(n²) 最好：O(n) 平均：O(n^1/3)
    /// </summary>
    public class ShellSort : ISort
    {
        public void Sort(int[] src)
        {
            var arr = src.Clone() as int[];

            // 每次进步缩小一半
            // 以此循环后，分组里面有序
            for (var skip = arr.Length / 2; skip > 0; skip /= 2)
            {
                for (var i = skip; i < arr.Length; i++)
                {
                    var temp = arr[i];
                    var j = i;

                    // 直接排序算法，只是下一个元素不是+1，而是加进步
                    // 挪位置
                    while (j - skip >= 0 && temp < arr[j - skip])
                    {
                        arr[j] = arr[j - skip];
                        j -= skip;
                    }

                    arr[j] = temp;
                }
            }

            Console.WriteLine("希尔排序：");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}