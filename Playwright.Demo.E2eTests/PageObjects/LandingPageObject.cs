using Microsoft.Playwright;
using SpecFlow.Actions.Playwright;

namespace Playwright.Demo.E2eTests.PageObjects;

public class LandingPageObject : BasePage
{
    private Interactions Interactions { get; }

    public LandingPageObject(BrowserDriver browserDriver) : base(browserDriver)
    {
        this.Interactions = new Interactions(this.Page);
    }

    public async Task VisitPage()
    {
        await this.Interactions.GoToUrl("https://playwright.dev/dotnet/");
    }

    public async Task<ILocator> HeroHeader()
    {
        return await this.GetLocator(".hero--primary h1.hero__title");
    }

    public async Task<ILocator> GetStartedButton()
    {
        return await this.GetLocator("a >> text=Get Started");
    }
}