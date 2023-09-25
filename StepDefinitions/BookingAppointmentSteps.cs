using BaseProject.PageObjects.BookingAppointment;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaseProject.StepDefinitions.BookingAppointment
{
    [Binding]
    public class BookingAppointmentSteps
    {
        private readonly BookingAppointmentPage _bookingAppoinmentPage;
        public BookingAppointmentSteps(IWebDriver driver)
        {
            _bookingAppoinmentPage = new BookingAppointmentPage(driver);
        }

        [Given(@"I am in CircleHealth Homepage")]
        public void GivenIAmInCircleHealthHomepage()
        {
            Assert.True(_bookingAppoinmentPage.VerifyCircleHealthHomepageWindowIsOpened());
        }

        [When(@"I click (.*) Button")]
        public void WhenIClickHomepageButton(string homepageButton)
        {
            _bookingAppoinmentPage.ClickHomepageButton(homepageButton);
        }
        [When(@"I enter (.*) in Search for a (.*) searchbar")]
        public void WhenIEnterSearchInSearchbar(string searchText, string search)
        {
            _bookingAppoinmentPage.EnterInSearchBar(searchText, search);
        }

        [When(@"I click (.*) in (.*) search Results")]
        public void WhenIClickButtonInSearchResults(string searchResultButton, string searchResult)
        {
            _bookingAppoinmentPage.ClickButtonInSearchResults(searchResultButton, searchResult);
        }

        [When(@"I click (.*) in Location search")]
        public void WhenIClickCurrentLocationInLocationSearch(string LocationButton)
        {
            _bookingAppoinmentPage.ClickButton(LocationButton);
        }


        [When(@"I click (.*) in Appointment Calender")]
        public void WhenIClickDateInAppointmentCalender(string appointmentDate)
        {
            _bookingAppoinmentPage.ClickDateInAppointmentCalender(appointmentDate);
        }

        [Then(@"I verify consultants availability and location provided to make my decision")]
        public void ThenIVerifyConsultantsAvailabilityAndLocation()
        {
            Assert.True(_bookingAppoinmentPage.VerifyConsultantsAvailabilityAndLocation());
        }
    }
}
