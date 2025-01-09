using ClassLibrary;

namespace TestProject
{
    [TestClass]
    public class TestMinimum
    {
        [TestMethod]
        public void TestNewMinimum_Create()
        {
            // Ініціадізація та налаштуванням
            int[] data = new int[3] { 4, 1, -3 };
            Minimum minimum = new Minimum(data);

            //Перевірка результату
            Assert.IsNotNull(minimum);
        }

        [TestMethod]
        public void TestNewMinimum_Error()
        {
            //Ініціадізація та Перевірка результату
            Assert.ThrowsException<ArgumentNullException>(
                () => {
                    int[] data = new int[0] { };
                    Minimum minimum = new Minimum(data); 
                }, 
            "Очікується ArgumentNullException");
        }

        /// <summary>
        /// TestMinimumSearch1
        /// </summary>
        [TestMethod]
        public void TestMinimumSearch1()
        {
            // Ініціадізація та налаштуванням
            int[] data = new int[3] { 4, 1, -3 };
            Minimum minimum = new Minimum(data);

            //Дії та функції
            int min = minimum.Search();

            //Перевірка результату
            Assert.AreEqual(-3, min);
        }

        /// <summary>
        /// TestMinimumSearch2
        /// </summary>
        [TestMethod]
        public void TestMinimumSearch2()
        {
            // Ініціадізація та налаштуванням
            int[] data = new int[3] { 6, 3, 9 };

            //Дії та функції
            int min = Minimum.Search(data);

            //Перевірка результату
            Assert.AreEqual(3, min);
        }
    }
}
