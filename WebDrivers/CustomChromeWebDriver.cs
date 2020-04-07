using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteRodolfo.WebDrivers
{
    public class CustomChromeWebDriver : SeleniumWebDriver
    {
        public CustomChromeWebDriver(Browser browser) : base(CustomProfile(), browser)
        {
        }

        private static IWebDriver CustomProfile()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("test-type");
            chromeOptions.AddArguments("--disable-extensions");

            return new ChromeDriver(chromeOptions);
        }
    }
}
