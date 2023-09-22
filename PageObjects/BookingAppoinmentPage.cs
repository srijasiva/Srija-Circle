using OpenQA.Selenium;

namespace BaseProject.PageObjects.BookingAppointment
{
    public class BookingAppointmentPage
    {
        private readonly IWebDriver driver;
        private readonly string _circleHealthHomepageWindow = "//a[@class='PrimaryNavigation__logo']";
        private readonly string _homepageText = "//span[text()='{0}']";
        private readonly string _searchFieldInput = "//input[@id='{0}']";
        private readonly string _searchButton = "//button[text()='{0}']";
        private readonly string _searchResultButton = "//h3[text() = '{1}']//following::a[text() = '{0}']";
        private readonly string _homepageButton = "//button[@title='{0}']"; 
        private readonly string _appointmentDate = "//span[contains(@aria-label, '{0}')]";
        private readonly string _resultCard = "//div[@class = 'consultant-result-card panel']";
       

        public BookingAppointmentPage(IWebDriver driver)
        {
            this.driver = driver;          
        }

        public bool VerifyCircleHealthHomepageWindowIsOpened()
        {
            return driver.FindElement(By.XPath(_circleHealthHomepageWindow)).Displayed;
        }

        public void ClickHomepageButton(string homepageButton)
        {
            driver.FindElement(By.XPath(String.Format(_homepageText, homepageButton))).Click();
        }

        public void EnterInSearchBar(string searchText, string search)
        {
            driver.FindElement(By.XPath(String.Format(_searchFieldInput, search))).SendKeys(searchText);
        }

        public void ClickSearchButton(string searchButton)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(String.Format(_searchButton, searchButton))).Click();
        }

        public void ClickButtonInSearchResults(string searchResultButton, string searchResult)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(String.Format(_searchResultButton, searchResultButton,searchResult))).Click();
        }

        public void ClickButton(string LocationButton)
        {
            driver.FindElement(By.XPath(String.Format(_homepageButton, LocationButton))).Click();
        }

        public void ClickDateInAppointmentCalender(string appointmentDate)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(String.Format(_appointmentDate, appointmentDate))).Click();
        }
        public bool VerifyConsultantsAvailabilityAndLocation()
        {
            return driver.FindElement(By.XPath(_resultCard)).Displayed;
        }        
    }
}