using NUnit.Framework;
using OpenQA.Selenium;

namespace CircleHealth.StepDefinitions
{
    [Binding]
    public class BookingAppointmentStepDefinitions
    {

        private IWebDriver driver;

        public BookingAppointmentStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the CircleHealth Web URL")]
        public void GivenEnterTheCircleHealthWebURL()
        {
            driver.Url = "https://www.circlehealthgroup.co.uk/";
            Thread.Sleep(1000);
        }

        [Then("I should see the Circle Health Homepage")]
        public void ThenIShouldSeeTheHomepage()
        {
            Assert.IsTrue(driver.Url.Contains("circlehealthgroup.co.uk"));            
        }
    }
}
