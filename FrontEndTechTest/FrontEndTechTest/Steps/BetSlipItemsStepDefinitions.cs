using FluentAssertions;
using FrontEndTechTest.Pages;
using Unity;
using TechTalk.SpecFlow;
using FrontEndTechTest.Core;

namespace FrontEndTechTest
{
    [Binding]
    public class BetSlipItemsStepDefinitions
    {
        string betslipCount;
        string newBetslipCount;

        public Homepage _homepage = UnityContainerFactory.GetContainer().Resolve<Homepage>();

        [Given(@"I have opened the Homepage")]
        public void GivenIHaveOpenedTheHomepage()
        {
            _homepage.OpenPage();
            _homepage.CookieConfirmation.Click();
        }

        [Given(@"the betslip is empty")]
        public void GivenTheBetslipIsEmpty()
        {
            betslipCount = _homepage.BetslipText.Text.ToString();
            betslipCount.Should().Be("BET SLIP (0)", "this is the default before a bet is added");
        }

        [When(@"I add an item to my betslip")]
        public void WhenIAddAnItemToMyBetslip()
        {
            _homepage.AvailableBets.Click();
        }

        [Then(@"the item is placed in my betslip")]
        public void ThenTheItemIsPlacedInMyBetslip()
        {
            newBetslipCount = _homepage.BetslipText.Text.ToString();
            newBetslipCount.Should().Be("BET SLIP (1)", "one item has been placed in the betslip");
        }

        [When(@"then I remove it")]
        public void WhenThenIRemoveIt()
        {
            _homepage.RemoveBetFromBetslipButton.Click();
        }

        [Then(@"the betslip is empty")]
        public void ThenTheBetslipIsEmpty()
        {
            betslipCount = _homepage.BetslipText.Text.ToString();
            betslipCount.Should().Be("BET SLIP (0)", "this is the default before a bet is added");
        }

    }
}
