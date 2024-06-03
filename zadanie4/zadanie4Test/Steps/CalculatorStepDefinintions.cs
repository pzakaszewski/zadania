﻿using TechTalk.SpecFlow;
using FluentAssertions;
using zadanie4;


namespace zadanie4Test.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinintions
    {
        private readonly Calculator _calculator;
        private int _result;


        public CalculatorStepDefinintions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
