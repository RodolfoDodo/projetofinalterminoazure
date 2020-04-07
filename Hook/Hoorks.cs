using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TesteRodolfo.WebDrivers;

namespace TesteRodolfo.Hook
{
    [Binding]

    public class Hooks
    {
        private BrowserSessionManager _browserSessionManager;

        public Hooks(BrowserSessionManager browserSessionManager)
        {
            _browserSessionManager = browserSessionManager;
        }

        [BeforeScenario]
        public void TestFixtureSetUp()
        {
            _browserSessionManager.GetBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _browserSessionManager.CloseBrowser();
        }


    }
}
