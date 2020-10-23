using TechTalk.SpecFlow;
using Calculator;
using Xunit;
namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorPricePTTotalStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private Calculator.Calculator calculator;
        public CalculatorPricePTTotalStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            calculator = new Calculator.Calculator();
        }

        [Given("the ptcountry is (.*)")]
        public void GivenThePTCountryIs(string country)
        {
            calculator.Country = country;
            
            //_scenarioContext.Pending();
        }

        [Given("the ptprice is (.*)")]
        public void GivenThePTCountryPriceIs(decimal number)
        {
            calculator.Price = number;
            
            //_scenarioContext.Pending();
        }

        [Given("the ptquantity is (.*)")]
        public void GivenThePTCountryQuantityIs(int number)
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

        [Then("the ptresult should be (.*)")]
        public void ThenThePTResultShouldBe(decimal result)
        {
            //TODO: implement assert (verification) logic
            Assert.Equal(result, calculator.GetTotal());
           // _scenarioContext.Pending();
        }
        

    }
}
