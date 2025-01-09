using ClassLibrary;

namespace TestProject
{

    [TestClass]
    public class TestCuboid
    {
        [TestMethod]
        public void TestNewCuboid_Create()
        {
            // Ініціадізація та налаштуванням
            Cuboid cuboid = new Cuboid(2, 3, 4);

            //Перевірка результату
            Assert.IsNotNull(cuboid);
        }
        [TestMethod]
        public void TestNewCuboid_Error()
        {
            //Ініціалізація та Перевірка результату
            Assert.ThrowsException<ArgumentNullException>(() => { Cuboid cuboid = new Cuboid(2, -1, 0); }, "Очікується ArgumentNullException");
        }

        [TestMethod]
        public void TestAreaCalc()
        {
            // Ініціадізація та налаштуванням
            Cuboid cuboid = new Cuboid(3, 4, 5);

            //Дії та функції
            double area = cuboid.Area();

            //Перевірка результату
            Assert.AreEqual(94, area);
        }
        [TestMethod]
        public void TestAreaStaticCalc()
        {
            // Ініціадізація та налаштуванням
            int a = 2, b = 3, h = 2;

            //Дії та функції
            double area = Cuboid.Area(a, b, h); 

            //Перевірка результату
            Assert.AreEqual(32, area);
        }
        
        [TestMethod]
        public void TestVCalc()
        {
            // Ініціадізація та налаштуванням
            Cuboid cuboid = new Cuboid(2, 4, 2);

            //Дії та функції
            double v = cuboid.V();

            //Перевірка результату
            Assert.AreEqual(16, v);
        }
        [TestMethod]
        public void TestVStaticCalc()
        {
            // Ініціадізація та налаштуванням
            int a = 2, b = 3, h = 2;

            //Дії та функції
            double v = Cuboid.V(a, b, h);

            //Перевірка результату
            Assert.AreEqual(v, 12);
        }
        [TestMethod]
        [Ignore]
        public void TestVStaticCalcError()
        {
            // Ініціадізація та налаштуванням
            int a = 2, b = 3, h = 2;

            //Дії та функції
            double v = Cuboid.V(a, b, h);

            //Перевірка результату
            Assert.AreEqual(v, 10);
        }
    }
}