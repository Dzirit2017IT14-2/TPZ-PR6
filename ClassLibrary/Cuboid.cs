namespace ClassLibrary
{
    /// <summary>
    /// Клас "Прямокутний паралеліпіпед" (кубоід)
    /// </summary>
    public class Cuboid
    {
        #region Параметри
        /// <summary> Дліна </summary>
        public double A { get; set; }
        /// <summary> Ширина </summary>
        public double B { get; set; }
        /// <summary> Висота </summary>
        public double H { get; set; }
        #endregion

        #region Конструктори
        /// <summary>
        /// Конструктор класу "Кубоід"
        /// </summary>
        /// <param name="a">дліна</param>
        /// <param name="b">ширина</param>
        /// <param name="h">висота</param>
        public Cuboid(double a, double b, double h)
        {
            Validation(a, b, h);
            A = a;
            B = b;
            H = h;
        }

        /// <summary>
        /// Конструктор класу "Кубоід" для куба
        /// </summary>
        /// <param name="a">сторона куба</param>
        public Cuboid(double a)
        {
            Validation(a, a, a);
            A = a;
            B = a;
            H = a;
        }
        #endregion

        #region Функції
        /// <summary>
        /// Функція для перевірки даних
        /// </summary>
        /// <param name="a">дліна</param>
        /// <param name="b">ширина</param>
        /// <param name="h">висота</param>
        /// <exception cref="ArgumentNullException">Якщо дані <= 0</exception>
        static void Validation(double a, double b, double h) 
        {
            if (a <= 0)
                throw new ArgumentNullException(nameof(a));
            if (b <= 0)
                throw new ArgumentNullException(nameof(b));
            if (h <= 0)
                throw new ArgumentNullException(nameof(h));
        }

        /// <summary>
        /// Розрахунок площі поверхні кубоіду
        /// </summary>
        /// <returns>Площа поверхні</returns>
        public double Area()
        {
            return 2 * A * B + 2 * A * H + 2 * B * H;
        }
        /// <summary>
        /// Розрахунок площі поверхні кубоіду
        /// </summary>
        /// <param name="a">дліна</param>
        /// <param name="b">ширина</param>
        /// <param name="h">висота</param>
        /// <returns>Площа поверхні</returns>
        public static double Area(double a, double b, double h)
        {
            Validation(a, b, h);
            return 2 * a * b + 2 * a * h + 2 * b * h;
        }
        /// <summary>
        /// Розрахунок об'єму кубоіду
        /// </summary>
        /// <returns>Об'єм</returns>
        public double V()
        {
            return A * B * H;
        }
        /// <summary>
        /// Розрахунок об'єму кубоіду
        /// </summary>
        /// <param name="a">дліна</param>
        /// <param name="b">ширина</param>
        /// <param name="h">висота</param>
        /// <returns>Об'єм</returns>
        public static double V(double a, double b, double h)
        {
            Validation(a, b, h);
            return a * b * h;
        }
        #endregion
    }
}
