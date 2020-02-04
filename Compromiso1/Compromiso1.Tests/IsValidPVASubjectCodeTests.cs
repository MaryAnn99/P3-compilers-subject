using System;
using System.Collections.Generic;
using NUnit.Framework;
using Compromiso1;
using System.Text;

namespace Compromiso1.Tests
{
    [TestFixture]
    public class IsValidPVASubjectCodeTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void WhenEmptyStringReturnFalse()
        {
            string input = "";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRecintoCSDReturnTrue()
        {
            string input = "CSD-1234-5679-MCE-256";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRecintoCSTIReturnTrue()
        {
            string input = "CSTI-5678-3241-MCE-178";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenCodigoAsignaturaISCReturnTrue()
        {
            string input = "CSD-1234-5679-ISC-230";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoSeparatorReturnFalse()
        {
            string input = "CSD17304988ISC314";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoFirstSeparatorReturnFalse()
        {
            string input = "CSD1730-4988-ISC-314";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoSecondSeparatorReturnFalse()
        {
            string input = "CSD-17304988-ISC-314";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoThirdSeparatorReturnFalse()
        {
            string input = "CSD-1730-4988ISC-314";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNoFourthSeparatorReturnFalse()
        {
            string input = "CSD-1730-4988-ISC314";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastDigitsAre1ReturnFalse()
        {
            string input = "CSD-1730-4988-ISC-3";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastDigitsAre2ReturnFalse()
        {
            string input = "CSD-1730-4988-ISC-32";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastDigitsAre4ReturnFalse()
        {
            string input = "CSD-1730-4988-ISC-3243";
            Validator validator = new Validator(input);
            bool output = validator.IsValidPVASubjectCode();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
    }
}
