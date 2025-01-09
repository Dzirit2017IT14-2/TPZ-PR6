namespace ClassLibrary
{
    /// <summary>
    /// Клас для пошуку мінімуму у виборцій
    /// </summary>
    public class Minimum
    {
        /// <summary> Дані </summary>
        public int[] Data { get; set; }
        /// <summary>
        /// Конструктор класу Minimum
        /// </summary>
        /// <param name="data">дані</param>
        public Minimum(int[] data)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException(nameof(data));
            Data = data;
        }
        /// <summary>
        /// Пошук мінімуму
        /// </summary>
        /// <returns>мінімум</returns>
        public int Search()
        {
            int min = int.MaxValue;
            foreach (int d in Data)
            {
                if (min > d)
                {
                    min = d;
                }
            }
            return min;
        }
        /// <summary>
        /// Пошук мінімуму
        /// </summary>
        /// <param name="data">дані</param>
        /// <returns>мінімум</returns>
        public static int Search(int[] data)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException(nameof(data));
            int min = int.MaxValue;
            foreach (int d in data)
            {
                if (min > d)
                {
                    min = d;
                }
            }
            return min;
        }
    }
}
