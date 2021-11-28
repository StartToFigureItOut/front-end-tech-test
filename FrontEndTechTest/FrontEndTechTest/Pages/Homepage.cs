using FrontEndTechTest.Core;
using OpenQA.Selenium;

namespace FrontEndTechTest.Pages
{
    public class Homepage : BasePage
    {
        public Homepage(IWebDriver driver) : base(driver)
        {
        }

        string url = "https://www.pokerstarssports.uk/";

        public void OpenPage()
        {
            Driver.Browser.Navigate().GoToUrl(url);
            Driver.Browser.Manage().Window.Maximize();
        }

        public IWebElement CookieConfirmation => WaitTillElementDisplayed("onetrust-accept-btn-handler", ElementLocator.ID, 10);

        public IWebElement BetslipText => WaitTillElementDisplayed("tab-nav-betslip", ElementLocator.ID, 10);

        public IWebElement AvailableBets => WaitTillElementDisplayed("button__bet__odds", ElementLocator.ClassName, 10);

        public IWebElement RemoveBetFromBetslipButton => WaitTillElementDisplayed("remove", ElementLocator.ClassName, 10);

        public IWebElement PriceFormatDropdown => WaitTillElementDisplayed("priceFormat", ElementLocator.ID, 10);

        public IWebElement SelectAPriceFormat(string format) => WaitTillElementDisplayed(format, ElementLocator.ID, 10);

        public void ClickAPriceFormat(string format)
        {
            IWebElement formatElement = WaitTillElementDisplayed(format, ElementLocator.ID, 10);

            if (formatElement.GetAttribute("class").Contains("currentFormat") != true)
            {
                formatElement.Click();
            }
        }
        

    }
}
