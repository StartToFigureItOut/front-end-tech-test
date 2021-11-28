using FrontEndTechTest.Core;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Unity;

namespace FrontEndTechTest
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            Driver.StartBrowser(30);
            UnityContainerFactory.GetContainer().RegisterInstance<IWebDriver>(Driver.Browser);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.StopBrowser();
        }
    }
}