using Microsoft.Playwright;
using SpecFlow.Actions.Playwright;

namespace Playwright.Demo.E2eTests.PageObjects;

public class BasePage
{
    public readonly Task<IBrowserContext> BrowserContext;
    public readonly Task<IPage> Page;

    public BasePage(BrowserDriver browserDriver)
    {
        this.BrowserContext = this.CreateBrowserContextAsync(browserDriver.Current);
        this.Page = this.CreatePageAsync(this.BrowserContext);
    }

    public async Task<ILocator> GetLocator(string selector, PageLocatorOptions? options = null)
    {
        return (await this.Page).Locator(selector, options);
    }

    private async Task<IBrowserContext> CreateBrowserContextAsync(Task<IBrowser> browser)
    {
        return await (await browser).NewContextAsync();
    }

    private async Task<IPage> CreatePageAsync(Task<IBrowserContext> browserContext)
    {
        return await (await browserContext).NewPageAsync();
    }
}