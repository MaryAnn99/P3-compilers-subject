using System;
using System.Collections.Generic;
using NUnit.Framework;
using Compromiso1;
using System.Text;

namespace Compromiso1.Tests
{
    [TestFixture]
    public class IsValidEmailAddressTests
    {
        [SetUp]
        public void Setup() { }
        // usuario@dominio
        [Test]
        public void WhenEmptyStringReturnFalse()
        {
            string input = "";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenDigitUserPartReturnTrue()
        {
            string input = "33@hotmail";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenEmptyUserPartReturnFalse()
        {
            string input = "@hotmail";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAlfanumericUserPartReturnTrue()
        {
            string input = "mm3i22@hotmail";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoAlfanumericUserPartReturnFalse()
        {
            string input = "m_3i*2+@hotmail";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenStartsWithNumberDomainPartReturnFalse()
        {
            string input = "mm3i22@6hotmail";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenEmptyDomainPartReturnFalse()
        {
            string input = "mm3i22@";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoDigitDomainPartReturnTrue()
        {
            string input = "mm3i22@gmail";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAlfanumericDomainPartReturnTrue()
        {
            string input = "mm3i22@m333hu12m3j4m5k6m78h90";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoAlfanumericDomainPartReturnFalse()
        {
            string input = "mm3i22@m_k@*m78h90";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoSeparatorReturnFalse()
        {
            string input = "mm3i22m";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoAtSignSeparatorReturnFalse()
        {
            string input = "mm3i*mm2m";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenDoubleAtSignSeparatorReturnFalse()
        {
            string input = "mm3i@@mm2m";
            Validator validator = new Validator(input);
            bool output = validator.IsValidEmailAddress();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
    }
}
