using TechTalk.SpecFlow;
using Calculator;
using Xunit;
namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorPriceFRTotalStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private Calculator.Calculator calculator;
        public CalculatorPriceFRTotalStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            calculator = new Calculator.Calculator();
        }

        [Given("the frcountry is (.*)")]
        public void GivenTheFrCountryIs(string country)
        {
            calculator.Country = country;
            
            //_scenarioContext.Pending();
        }

        [Given("the frprice is (.*)")]
        public void GivenTheFrCountryPriceIs(decimal number)
        {
            calculator.Price = number;
            
            //_scenarioContext.Pending();
        }

        [Given("the frquantity is (.*)")]
        public void GivenTheFrCountryQuantityIs(int number)
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

        [Then("the frresult should be (.*)")]
        public void ThenTheFrResultShouldBe(decimal result)
        {
            //TODO: implement assert (verification) logic
            Assert.Equal(result, calculator.GetTotal());
           // _scenarioContext.Pending();
        }
        

    }
}
