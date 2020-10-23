using TechTalk.SpecFlow;
using Calculator;
using Xunit;
namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorPriceDETotalStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private Calculator.Calculator calculator;
        public CalculatorPriceDETotalStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            calculator = new Calculator.Calculator();
        }

        [Given("the decountry is (.*)")]
        public void GivenTheDeCountryIs(string country)
        {
            calculator.Country = country;
            
            //_scenarioContext.Pending();
        }

        [Given("the deprice is (.*)")]
        public void GivenTheDeCountryPriceIs(decimal number)
        {
            calculator.Price = number;
            
            //_scenarioContext.Pending();
        }

        [Given("the dequantity is (.*)")]
        public void GivenTheDeCountryQuantityIs(int number)
        {
            calculator.Quantity = number;
            
            //_scenarioContext.Pending();
        }


        // [When("the two numbers are added")]
        // public void WhenTheTwoNumbersAreAdded()
        // {
        //     calculator.Add();

        //     //_scenarioContext.Pending();
        // }

        [Then("the deresult should be (.*)")]
        public void ThenTheDeResultShouldBe(decimal result)
        {
            //TODO: implement assert (verification) logic
            Assert.Equal(result, calculator.GetTotal());
           // _scenarioContext.Pending();
        }
        

    }
}
