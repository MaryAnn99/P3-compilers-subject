using NUnit.Framework;
using Compromiso1;

namespace Compromiso1.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        // ""
        // "2019-9999"
        // "1962-0000"
        // "1962-1111"

        [Test]
        public void WhenEmptyStringReturnFalse()
        {
            string input = "";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }

        [Test]
        public void WhenCorrectStringReturnTrue()
        {
            string input = "2019-9999";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers0ReturnTrue()
        {
            string input = "1962-0000";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers1ReturnTrue()
        {
            string input = "1962-1111";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers2ReturnTrue()
        {
            string input = "1962-2222";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers3ReturnTrue()
        {
            string input = "1962-3333";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers4ReturnTrue()
        {
            string input = "1962-4444";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers5ReturnTrue()
        {
            string input = "1962-5555";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers6ReturnTrue()
        {
            string input = "1962-6666";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers7ReturnTrue()
        {
            string input = "1962-7777";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers8ReturnTrue()
        {
            string input = "1962-8888";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenLastNumbers9ReturnTrue()
        {
            string input = "1962-9999";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1962ReturnTrue()
        {
            string input = "1962-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1963ReturnTrue()
        {
            string input = "1963-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1964ReturnTrue()
        {
            string input = "1964-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1965ReturnTrue()
        {
            string input = "1965-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1966ReturnTrue()
        {
            string input = "1966-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1967ReturnTrue()
        {
            string input = "1967-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1968ReturnTrue()
        {
            string input = "1968-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1969ReturnTrue()
        {
            string input = "1969-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1970ReturnTrue()
        {
            string input = "1970-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1971ReturnTrue()
        {
            string input = "1971-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1972ReturnTrue()
        {
            string input = "1972-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1973ReturnTrue()
        {
            string input = "1973-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1974ReturnTrue()
        {
            string input = "1974-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1975ReturnTrue()
        {
            string input = "1975-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1976ReturnTrue()
        {
            string input = "1976-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1977ReturnTrue()
        {
            string input = "1977-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1978ReturnTrue()
        {
            string input = "1978-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1979ReturnTrue()
        {
            string input = "1979-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1980ReturnTrue()
        {
            string input = "1980-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1981ReturnTrue()
        {
            string input = "1981-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1982ReturnTrue()
        {
            string input = "1982-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1983ReturnTrue()
        {
            string input = "1983-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1984ReturnTrue()
        {
            string input = "1984-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1985ReturnTrue()
        {
            string input = "1985-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1986ReturnTrue()
        {
            string input = "1986-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1987ReturnTrue()
        {
            string input = "1987-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1988ReturnTrue()
        {
            string input = "1988-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1989ReturnTrue()
        {
            string input = "1989-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1990ReturnTrue()
        {
            string input = "1990-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1991ReturnTrue()
        {
            string input = "1991-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1992ReturnTrue()
        {
            string input = "1992-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1993ReturnTrue()
        {
            string input = "1993-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1994ReturnTrue()
        {
            string input = "1994-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1995ReturnTrue()
        {
            string input = "1995-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1996ReturnTrue()
        {
            string input = "1996-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1997ReturnTrue()
        {
            string input = "1997-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1998ReturnTrue()
        {
            string input = "1998-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1999ReturnTrue()
        {
            string input = "1999-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2000ReturnTrue()
        {
            string input = "2000-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2001ReturnTrue()
        {
            string input = "2001-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2002ReturnTrue()
        {
            string input = "2002-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2003ReturnTrue()
        {
            string input = "2003-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2004ReturnTrue()
        {
            string input = "2004-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2005ReturnTrue()
        {
            string input = "2005-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2006ReturnTrue()
        {
            string input = "2006-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2007ReturnTrue()
        {
            string input = "2007-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2008ReturnTrue()
        {
            string input = "2008-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2009ReturnTrue()
        {
            string input = "2009-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2010ReturnTrue()
        {
            string input = "2010-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2011ReturnTrue()
        {
            string input = "2011-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2012ReturnTrue()
        {
            string input = "2012-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2013ReturnTrue()
        {
            string input = "2013-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2014ReturnTrue()
        {
            string input = "2014-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2015ReturnTrue()
        {
            string input = "2015-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2016ReturnTrue()
        {
            string input = "2016-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2017ReturnTrue()
        {
            string input = "2017-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2018ReturnTrue()
        {
            string input = "2018-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2019ReturnTrue()
        {
            string input = "2019-1234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = true;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear1961ReturnFalse()
        {
            string input = "1961-5678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenRegistrationYear2020ReturnFalse()
        {
            string input = "2020-9106";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenNumberSeparatorReturnFalse()
        {
            string input = "196805678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenAnotherCharSeparatorReturnFalse()
        {
            string input = "1990*5678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSpaceSeparatorReturnFalse()
        {
            string input = "1990 5678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize3RegistrationYearReturnFalse()
        {
            string input = "199-5678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize2RegistrationYearReturnFalse()
        {
            string input = "20-5678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize1RegistrationYearReturnFalse()
        {
            string input = "1-5678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize0RegistrationYearReturnFalse()
        {
            string input = "-5678";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize0RegistrationYearAndNoSeparatorReturnFalse()
        {
            string input = "1999";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize5RegistrationYearReturnFalse()
        {
            string input = "19999-2345";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize3RegistrationNumberReturnFalse()
        {
            string input = "1999-234";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize2RegistrationNumberReturnFalse()
        {
            string input = "1999-23";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize1RegistrationNumberReturnFalse()
        {
            string input = "1999-2";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSize0RegistrationNumberReturnFalse()
        {
            string input = "1999-";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenFirstDigit3RegistrationYearReturnFalse()
        {
            string input = "3000-8646";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenFirstDigit4RegistrationYearReturnFalse()
        {
            string input = "4010-8646";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenFirstDigit0RegistrationYearReturnFalse()
        {
            string input = "0000-8646";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSecondDigitAfter2Is1RegistrationYearReturnFalse()
        {
            string input = "2100-8646";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenSecondDigitAfter1Is8RegistrationYearReturnFalse()
        {
            string input = "1800-8646";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
        [Test]
        public void WhenThirdDigitAfter1Is5RegistrationYearReturnFalse()
        {
            string input = "1950-8646";
            Validator validator = new Validator(input);
            bool output = validator.IsValidMatriculationNumber();
            bool expected = false;
            Assert.IsTrue((output == expected));
        }
    }
}