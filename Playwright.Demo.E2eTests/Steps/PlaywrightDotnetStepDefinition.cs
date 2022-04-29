using NUnit.Framework;
using Playwright.Demo.E2eTests.PageObjects;
using TechTalk.SpecFlow;

namespace Playwright.Demo.E2eTests.Steps;

[Binding]
public class PlaywrightDotnetSteps
{
    public PlaywrightDotnetSteps(LandingPageObject landingPage)
    {
        this.LandingPage = landingPage;
    }

    private LandingPageObject LandingPage { get; }

    [Given(@"I am a visitor")]
    public void GivenIAmAVisitor()
    {
    }

    [When(@"I enter the homepage")]
    public async Task WhenIEnterTheHomePage()
    {
        await this.LandingPage.VisitPage();
    }

    [Then(@"I should see '(.*)'")]
    public async Task ThenIShouldSee(string expected)
    {
        var locator = await this.LandingPage.HeroHeader();
        var actual = await locator.TextContentAsync();

        Assert.AreEqual(expected, actual);
    }

    [Then(@"I should see the Get Started link")]
    public async Task ThenIShouldSeeTheLink()
    {
        var locator = await this.LandingPage.GetStartedButton();

        Assert.True(await locator.IsVisibleAsync());
    }
}