using OpenQA.Selenium;
using System.Configuration;
using FluentAssertions;
using SeleniumWebdriverHelpers;

namespace AutomacaoCuponagem.PageObjects
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        public void Autenticar(string CNPJ, string Senha, string Captcha )
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLBase"]);
            driver.WaitElement(By.Id("Login")).SendKeys(ConfigurationManager.AppSettings["CNPJ"]);
            driver.WaitElement(By.Id("Senha")).SendKeys(ConfigurationManager.AppSettings["Senha"]);
            driver.WaitElement(By.Id("CaptchaInputText")).SendKeys(ConfigurationManager.AppSettings["Captcha"]);
            driver.WaitElement(By.Id("avancar")).Click();
            driver.WaitElement(By.Id("ddlListaCnpj")).Text.Should().Contain(ConfigurationManager.AppSettings["CNPJ"]);
         }

        public void IrParatelaLogin() {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLBase"]);
        }

        public void PreencherCNPJ()
        {
            driver.WaitElement(By.Id("Login")).SendKeys(ConfigurationManager.AppSettings["CNPJ"]);
        }

        public void PreencherSenha()
        {
            driver.WaitElement(By.Id("Senha")).SendKeys(ConfigurationManager.AppSettings["Senha"]);
        }

        public void PreencherCaptcha()
        {
            driver.WaitElement(By.Id("CaptchaInputText")).SendKeys(ConfigurationManager.AppSettings["Captcha"]);
            //thread.
        }


    }
}


