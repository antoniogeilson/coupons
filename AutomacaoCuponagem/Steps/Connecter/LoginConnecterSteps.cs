using AutomacaoCuponagem.PageObjects.Connecter;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Steps.Connecter
{
    [Binding]
    public class LoginConnecterSteps
    {
        private IWebDriver driver;
        private LoginConnecterPage loginConnecterPage;
        private ListaCampanhasPage listaCampanhasPage;
        
        public LoginConnecterSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginConnecterPage = new LoginConnecterPage(driver);
            listaCampanhasPage = new ListaCampanhasPage(driver);
        }

        [Given(@"que estou na tela de Login do Connecter")]
        public void DadoQueEstouNaTelaDeLoginDoConnecter()
        {
            loginConnecterPage.AcessarURLConnecter();
        }       

        [Given(@"preencho os campos Usuario e Senha\(Connecter\)")]
        public void DadoPreenchoOsCamposUsuarioESenhaConnecter()
        {
            loginConnecterPage.PreencherCamposLoginValido();
        }        

        [When(@"pressiono botão Entrar\(Connecter\)")]
        public void QuandoPressionoBotaoEntrarConnecter()
        {
            loginConnecterPage.ClicarBotaoEntrar();
        }
        
        [Then(@"visualizo a tela Painel de Campanhas")]
        public void EntaoVisualizoATelaPainelDeCampanhas()
        {
            listaCampanhasPage.ValidarListaCampanhas();
        }
    }
}
