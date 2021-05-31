using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Compression.Compression;

namespace CompressionTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CompressionString_aabbbcccdd_a2b3c4d1()
        {
            //arrange
            string str = "aabbbccccdd";
            string expected = "a2b3c4d2";
        
            //act
            string actual = CompressionString(str);
        
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompressionString_abcde_abcde()
        {
            //arrange
            string str = "abcde";
            string expected = "abcde";

            //act
            string actual = CompressionString(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompressionString_Empty_Empty()
        {
            //arrange
            string str = "";
            string expected = "";

            //act
            string actual = CompressionString(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompressionString_Null_ThrowArgumentNullException()
        {
            //arrange
            string str = null;

            //act + assert
            Assert.ThrowsException<ArgumentNullException>(() => CompressionString(str));
        }
    }
}