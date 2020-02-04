using System;
using System.Collections.Generic;
using NUnit.Framework;
using Compromiso1;
using System.Text;

namespace Compromiso1.Tests
{
    [TestFixture]
    public class IsValidDominicanPhoneNumberTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void WhenAreaCode809ReturnTrue()
        {
            string input = "809-256-2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAreaCode829ReturnTrue()
        {
            string input = "829-974-8643";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAreaCode849ReturnTrue()
        {
            string input = "849-789-3696";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenEmptyStringReturnFalse()
        {
            string input = "";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAreaCode309ReturnFalse()
        {
            string input = "309-256-2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAreaCode839ReturnFalse()
        {
            string input = "839-256-2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAreaCode848ReturnFalse()
        {
            string input = "848-256-2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoSeparatorReturnFalse()
        {
            string input = "8092562345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoFirstSeparatorReturnFalse()
        {
            string input = "809256-2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoSecondSeparatorReturnFalse()
        {
            string input = "809-2562345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSpaceSeparatorReturnFalse()
        {
            string input = "809 256 2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoHyphenSeparatorReturnFalse()
        {
            string input = "809*256/2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When3NumbersInThirdPartReturnFalse()
        {
            string input = "809-256-234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void When4NumbersInSecondPartReturnFalse()
        {
            string input = "809-2569-2342";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoDigitReturnFalse()
        {
            string input = "80c-269-2342";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoValidPhoneReturnFalse()
        {
            string input = "*80c";
            Validator validator = new Validator(input);
            bool output = validator.IsValidDominicanPhoneNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
    }
}
        