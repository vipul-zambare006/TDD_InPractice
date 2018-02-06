using CodingTest1;
using NUnit.Framework;
using System;

namespace BrackerChecker.UnitTests
{
    [TestFixture]
    public class ParathesisMatcherTest
    {
        ParathesisMatcher bracketChecker;

        [SetUp]
        public void TestSetup()
        {
            bracketChecker = new ParathesisMatcher();
        }

        [Test]
        public void positiveTest_forMatchingBrackets()
        {
            var inputString = "{{}}{}{}{}()";
            var result = bracketChecker.checkBrackets(inputString);

            Assert.IsTrue(result);
        }

        [Test]
        public void negative_test_for_single_bracket()
        {
            var inputString = "(";
            var result = bracketChecker.checkBrackets(inputString);
            Assert.IsFalse(result);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void negative_test1_for_all_closing_brackets()
        {
            var inputString = "}}}}}}}";
            var result = bracketChecker.checkBrackets(inputString);
            Assert.IsFalse(result);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void negative_test2_for_misMatching_brackets()
        {
            var inputString = "{(})";
            var result = bracketChecker.checkBrackets(inputString);
            Assert.IsFalse(result);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void negative_test1_for_all_opening_brackets()
        {
            var inputString = "{{{(((([{[[";
            var result = bracketChecker.checkBrackets(inputString);
            Assert.IsFalse(result);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void should_throw_exception_when_there_is_empty_brackets_string()
        {
            var inputString = "";
            Assert.Throws(typeof(ArgumentNullException), () => bracketChecker.checkBrackets(inputString));
        }

        [Test]
        public void should_throw_invalid_inputException_when_numeric_input_provided()
        {
            var inputString = "123343413414";
            Assert.Throws(typeof(InvalidOperationException), () => bracketChecker.checkBrackets(inputString));
        }

        [Test]
        public void should_throw_invalid_inputException_when_alphanumeric_input_provided()
        {
            var inputString = "asdadad1212";
            Assert.Throws(typeof(InvalidOperationException), () => bracketChecker.checkBrackets(inputString));
        }

        [TearDown]
        public void TestTearDown()
        {

        }
    }
}
