using OpenQA.Selenium;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;
using System.Configuration;

namespace AutomacaoCuponagem.PageObjects.Connecter
{
    public class LoginConnecterPage
    {
        private IWebDriver driver;

        public LoginConnecterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Acessar URL do Connecter
        public void AcessarURLConnecter()
        {
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLConnecter"]);
        }

        //Preencher Campos de Login
        public void PreencherCamposLoginValido()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("username")).SendKeys(ConfigurationManager.AppSettings["ConnecterUsuario"]);
            driver.FindElement(By.Id("password")).SendKeys(ConfigurationManager.AppSettings["ConnecterSenha"]);
        }

        //Clicar Botão Entrar
        public void ClicarBotaoEntrar()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div/div/form/button")).Click();
        }
        
    }
}

