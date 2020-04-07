using Coypu;
using Coypu.Drivers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace TesteRodolfo.WebDrivers
{
    [Binding]
    public class BrowserSessionManager
    {
        private BrowserSession browser;

        private Browser browserName;

        public BrowserSession Browser()
        {
            return browser;
        }

        public BrowserSession GetBrowser()
        {
            if (browser != null)
                return browser;

            var sessionConfigurationForChromeHeadless = new SessionConfiguration()
            {
                Driver = typeof(CustomChromeHeadlessWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                AppHost = "https://specflow.org/", // whatever url you want
                Timeout = TimeSpan.FromSeconds(2)
            };
            browser = new BrowserSession(sessionConfigurationForChromeHeadless);
            browser.ResizeTo(1124, 850);

            return browser;
        }

        public void CloseBrowser()
        {
            browser.Dispose();
        }


        private Browser GetBrowserName()
        {
            var browserType = TestContext.Parameters["BROWSER"];
            switch (browserType)
            {
                case "CHROME":
                    browserName = Coypu.Drivers.Browser.Chrome;
                    break;

                case "INTERNETEXPLORER":
                    browserName = Coypu.Drivers.Browser.InternetExplorer;
                    break;

                case "FIREFOX":
                    browserName = Coypu.Drivers.Browser.Firefox;
                    break;

                default:
                    browserName = Coypu.Drivers.Browser.Chrome;
                    break;
            }
            return browserName;
        }

    }
}
