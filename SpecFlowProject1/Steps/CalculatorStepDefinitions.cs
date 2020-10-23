using Calculator;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        
        private bool isSetup = false;
        private float orderTotal = 0;


        [Given(@"the project is setup")]
        public void GivenTheProjectIsSetup()
        {
            isSetup = Calculator.OrderCalculator.ProjectSetup();
            //_scenarioContext.Pending();
        }

        [Then(@"the test is passing")]
        public void ThenTheTestIsPassing()
        {
            Assert.True(isSetup);
        }

        [Given(@"that the quantity is (.*)")]
        public void GivenThatTheQuantityIs(int p0)
        {
            OrderCalculator.Quantity = p0;
        }

        [Given(@"the price is (.*)")]
        public void GivenThePriceIs(float p0)
        {
            OrderCalculator.Price = p0;
            //ScenarioContext.Current.Pending();
        }

        
        [When(@"the i calculate the order total")]
        public void WhenTheICalculateTheOrderTotal()
        {
            orderTotal = OrderCalculator.CalculateOrderTotal();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(float p0)
        {
            Assert.Equal(p0, orderTotal);
        }

        [Given(@"the country code is (.*)")]
        public void GivenTheCountryCodeIs(string p0)
        {
            orderTotal = OrderCalculator.CalculateOrderTotal();
            OrderCalculator.CalculateOrderTotalBasedOnCountryTaxRate(orderTotal);
        }



    }
}
