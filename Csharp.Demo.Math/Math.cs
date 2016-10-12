namespace Csharp.Demo.Math
{
    public class Math
    {
        /// <summary>
        /// 获取数组最大值
        /// </summary>
        /// <param name="array">数组</param>
        /// <returns>最大值</returns>
        public static int GetMaxValue(int[] array)
        {
            int maxVal = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            return maxVal;
        }
        /// <summary>
        /// 获取数组最小值
        /// </summary>
        /// <param name="array">数组</param>
        /// <returns>最小值</returns>
        public static int GetMinValue(int[] array)
        {
            int minVal = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                }
            }
            return minVal;
        }
    }
}
