using System;

namespace sort
{
    /// <summary>
    /// 快速排序
    /// 选择某个基准位（通常是每组第一个），将大的放它后面，小的放前面，
    /// 然后大的部分再排序，小的部分再排序，
    /// 递归如此
    /// 
    /// 最差：O(n²) 最佳，平均：O(nlog₂n)
    /// </summary>
    public class QuickSort : ISort
    {
        public void Sort(int[] src)
        {
            var arr = src.Clone() as int[];

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("快速排序：");
            Console.WriteLine(string.Join(" ", arr));
        }

        private void Sort(int[] arr, int low, int high)
        {
            if (low > high) return;

            var mid = SortPartion(arr, low, high);

            Sort(arr, low, mid - 1);
            Sort(arr, mid + 1, high);
        }

        private int SortPartion(int[] arr, int low, int high)
        {
            // 表示基准数，比它大的放右边，比它小的放左边
            var x = arr[low];

            // 每轮循环，会把从右到左相对 x 小的放到左边低位，
            // 从左到右相对 x 大的放到右边，如果右边有挪到左边的位，就放那个位；如果没有挪过，就放最高位
            while (low < high)
            {
                // 找到右边第一个比 x 小的下标
                // 如果右边都比 x 大，最后 high=low
                while (low < high && x <= arr[high])
                    high--;
                arr[low] = arr[high];

                // 找到左边第一个比 x 大的下标
                // 如果左边都比 x 小，最后 high=low
                while (low < high && x >= arr[low])
                    low++;
                arr[high] = arr[low];
            }

            arr[low] = x;

            return low;
        }
    }
}