using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals.Classes;
using RomanNumerals.CustomException;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestInvalidInputs()
        {
            ConvertNumber convertNumber = new ConvertNumber();

            try
            {
                convertNumber.IntToRomanNumeral(0);
                Assert.Fail();
            }
            catch (InputValueException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }

            try
            {
                convertNumber.IntToRomanNumeral(-50);
                Assert.Fail();
            }
            catch (InputValueException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }

            try
            {
                convertNumber.IntToRomanNumeral(3001);
                Assert.Fail();
            }
            catch (InputValueException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestValidInputs()
        {
            try
            {
                ConvertNumber convertNumber = new ConvertNumber();
                Assert.AreEqual(convertNumber.IntToRomanNumeral(1), "I");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(7), "VII");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(10), "X");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(30), "XXX");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(48), "XLVIII");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(49), "XLIX");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(88), "LXXXVIII");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(300), "CCC");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(555), "DLV");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(999), "CMXCIX");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(1234), "MCCXXXIV");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(2222), "MMCCXXII");
                Assert.AreEqual(convertNumber.IntToRomanNumeral(3000), "MMM");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestStress()
        {
            try
            {
                ConvertNumber convertNumber = new ConvertNumber();

                for (int i = 1; i <= 3000; i++)
                    Assert.IsNotNull(convertNumber.IntToRomanNumeral(1));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
