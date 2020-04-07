using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TesteRodolfo.WebDrivers;

namespace TesteRodolfo.Pages
{
    public class GooglePage
    {
        private BrowserSessionManager _browserSessionManager;

        public GooglePage(BrowserSessionManager browserSessionManager)
        {
            _browserSessionManager = browserSessionManager;
        }

        public void GetUrl(string url)
        {
            _browserSessionManager.Browser().Visit(url);
            Thread.Sleep(5000);
        }

    }

}
