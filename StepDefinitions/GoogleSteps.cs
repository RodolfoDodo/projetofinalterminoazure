using System;
using TechTalk.SpecFlow;
using TesteRodolfo.Pages;

namespace TesteRodolfo.StepDefinitions
{
    [Binding]
    public class GoogleSteps
    {
        private GooglePage _googlePage;

        public GoogleSteps(GooglePage googlePage)
        {
            _googlePage = googlePage;
        }
        [Given(@"que acesso a pagina da globoooo do galor ""(.*)""")]
        public void GivenQueAcessoAPaginaDaGlobooooDoGalor(string url)
        {
            _googlePage.GetUrl(url);

        }
    }
}
