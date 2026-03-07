using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab02;

namespace Lab02.Tests
{
    [TestClass]
    public class NumberConverterTests
    {
        [TestMethod]
        public void ConvertToAllSystems_ValidPositiveNumber_ReturnsCorrect()
        {
            Assert.IsTrue(NumberConverter.ConvertToAllSystems(42, out string bin, out string oct, out string hex));
            Assert.AreEqual("101010", bin);
            Assert.AreEqual("52", oct);
            Assert.AreEqual("2A", hex);
        }

        [TestMethod]
        public void ConvertToAllSystems_Zero_ReturnsCorrect()
        {
            Assert.IsTrue(NumberConverter.ConvertToAllSystems(0, out string bin, out string oct, out string hex));
            Assert.AreEqual("0", bin);
            Assert.AreEqual("0", oct);
            Assert.AreEqual("0", hex);
        }

        [TestMethod]
        public void ConvertToAllSystems_NegativeNumber_ReturnsFalse()
        {
            Assert.IsFalse(NumberConverter.ConvertToAllSystems(-1, out _, out _, out _));
        }
    }

    [TestClass]
    public class BinaryCalculatorTests
    {
        [TestMethod]
        public void AddBinary_ValidInputs_ReturnsCorrect()
        {
            Assert.IsTrue(BinaryCalculator.AddBinary("1010", "0110", out string bin, out long dec));
            Assert.AreEqual("10000", bin);
            Assert.AreEqual(16L, dec);
        }

        [TestMethod]
        public void AddBinary_InvalidInput_ReturnsFalse()
        {
            Assert.IsFalse(BinaryCalculator.AddBinary("1010", "1020", out _, out _));
        }

        [TestMethod]
        public void AddBinary_EmptyInput_ReturnsFalse()
        {
            Assert.IsFalse(BinaryCalculator.AddBinary("", "101", out _, out _));
        }
    }

    [TestClass]
    public class BitVisualizerTests
    {
        // Тест рисования — минимальный: проверяем, что метод не падает при вызове.
        // В .NET Framework System.Drawing доступен напрямую.
        [TestMethod]
        public void DrawBits_DoesNotThrowOnValidInput()
        {
            using var bmp = new System.Drawing.Bitmap(200, 100);
            using var g = System.Drawing.Graphics.FromImage(bmp);

            try
            {
                BitVisualizer.DrawBits(g, "1010", 10, 10);
                Assert.IsTrue(true, "DrawBits не выбросил исключение.");
            }
            catch (System.Exception ex)
            {
                Assert.Fail($"DrawBits выбросил исключение: {ex}");
            }
        }

        [TestMethod]
        public void DrawCaption_DoesNotThrow()
        {
            using var bmp = new System.Drawing.Bitmap(200, 100);
            using var g = System.Drawing.Graphics.FromImage(bmp);
            using var font = new System.Drawing.Font("Arial", 10);

            try
            {
                BitVisualizer.DrawCaption(g, 10, "1010", 10, 50, font);
                Assert.IsTrue(true, "DrawCaption не выбросил исключение.");
            }
            catch (System.Exception ex)
            {
                Assert.Fail($"DrawCaption выбросил исключение: {ex}");
            }
        }
    }
}