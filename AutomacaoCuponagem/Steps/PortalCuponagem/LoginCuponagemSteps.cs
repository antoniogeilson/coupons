using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Steps
{
    [Binding]
    public class LoginCuponagemSteps
    {
        //Criar Construtores do driver e Classe
        private IWebDriver driver;
        private LoginCuponagemPage loginCuponagemPage;
        private PainelPromocoesPage painelPromocoesPage;
                
        public LoginCuponagemSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginCuponagemPage = new LoginCuponagemPage(driver);
            painelPromocoesPage = new PainelPromocoesPage(driver);
        }

        [Given(@"que estou na tela de Login Cuponagem Fake")]
        public void DadoQueEstouNaTelaDeLoginCuponagemFake()
        {
            loginCuponagemPage.AcessarURLLoginPage();           
        }
        
        [Given(@"preencho os campos CNPJ e Token")]
        public void DadoPreenchoOsCamposCNPJEToken()
        {
            loginCuponagemPage.PreencherDados();
        }
        
        [When(@"pressiono botão Entrar")]
        public void QuandoPressionoBotaoEntrar()
        {
            loginCuponagemPage.ClicarBotaoEntrar();
        }

        [Then(@"visualizo a tela Painel de Promocoes")]
        public void EntaoVisualizoATelaPainelDePromocoes()
        {
            painelPromocoesPage.ValidarLoginOK();
        }
    }
}
