using System;
using System.Collections.Generic;
using NUnit.Framework;
using Compromiso1;
using System.Text;

namespace Compromiso1.Tests
{
        
    [TestFixture]
    public class IsValidURLAddressTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void WhenEmptyStringReturnFalse()
        {
            string input = "";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When1()
        {
            string input = "https://docsawsamazoncom/";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }

        [Test]
        public void When2()
        {
            string input = "https://docsawsamazoncom//";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When3()
        {
            string input = "https//amazon/";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }

        [Test]
        public void When4()
        {
            string input = "https:/path/";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When5()
        {
            string input = "https://amazon/path1/path2";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When6()
        {
            string input = "https://amazon/path1/path2?k=7";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When7()
        {
            string input = "https://amazon/path1/path2?k=";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When8()
        {
            string input = "https://amazon/path1/path2?k";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When9()
        {
            string input = "https://amazon/path1/path2?";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When10()
        {
            string input = "https://amazon/path1/path////";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When11()
        {
            string input = "https://amazon/path1/path////#";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When12()
        {
            string input = "https://amazon/path1/path////#onthepage";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When13()
        {
            string input = "https://amazon/";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When14()
        {
            string input = "https://amazon/#";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When15()
        {
            string input = "https://userinfo:@amazon:1/#";
            Validator validator = new Validator(input);
            bool output = validator.IsValidURLAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
    }
}
