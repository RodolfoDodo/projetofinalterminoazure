Feature: Google
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	  var sessionConfigurationForChrome = new SessionConfiguration()
            {
                Driver = typeof(CustomChromeWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                AppHost = "https://globoesporte.globo.com/futebol/times/atletico-mg/", // whatever url you want
                Timeout = TimeSpan.FromSeconds(2)
            };
            browser = new BrowserSession(sessionConfigurationForChrome);
            browser.MaximiseWindow();


             var sessionConfigurationForChromeHeadless = new SessionConfiguration()
            {
                Driver = typeof(CustomChromeHeadlessWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                AppHost = "https://specflow.org/", // whatever url you want
                Timeout = TimeSpan.FromSeconds(2)
            };
            browser = new BrowserSession(sessionConfigurationForChromeHeadless);
            browser.ResizeTo(1124, 850);



@mytag

Scenario: Acesso a pagina 
    Given que acesso a pagina da globoooo do galor "https://globoesporte.globo.com/futebol/times/atletico-mg/"

