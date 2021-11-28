using FrontEndTechTest.Core;
using FrontEndTechTest.Pages;
using Unity;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace FrontEndTechTest
{
    [Binding]
    public class OddsFormatStepDefinitions
    {
        public Homepage _homepage = UnityContainerFactory.GetContainer().Resolve<Homepage>();

        [Given(@"I am browsing odds on the Homepage")]
        public void GivenIAmBrowsingOddsOnTheHomepage()
        {
            _homepage.AvailableBets.Displayed.Should().Be(true, "on there homepage there should be some bets to select from");
        }

        [When(@"I select the '([^']*)' of odds")]
        public void WhenISelectTheOfOdds(string oddsStyle)
        {         
            _homepage.PriceFormatDropdown.Click();
            _homepage.SelectAPriceFormat(oddsStyle).Click();
            _homepage.SelectAPriceFormat(oddsStyle).GetAttribute("class").Contains("currentFormat").Should().BeTrue(oddsStyle + "should be selected");
        }

        [Then(@"the odds on the page should now be displayed with the expected '([^']*)'")]
        public void ThenTheOddsOnThePageShouldNowBeDisplayedWithTheExpected(string format)
        {
            _homepage.AvailableBets.Text.Should().Contain(format, "this character would be expected in this format");
        }

    }
}
