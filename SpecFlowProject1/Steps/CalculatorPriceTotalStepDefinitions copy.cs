using TechTalk.SpecFlow;
using Calculator;
using Xunit;
namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorPriceTotalStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private Calculator.Calculator calculator;
        public CalculatorPriceTotalStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            calculator = new Calculator.Calculator();
        }
        
        [Given("the price is (.*)")]
        public void GivenThePriceIs(decimal number)
        {
            calculator.Price = number;
            
            //_scenarioContext.Pending();
        }

        [Given("the quantity is (.*)")]
        public void GivenTheQuantityIs(int number)
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

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(decimal result)
        {
            //TODO: implement assert (verification) logic
            Assert.Equal(result, calculator.CalculateQuantityPrice());
           // _scenarioContext.Pending();
        }
        

    }
}
