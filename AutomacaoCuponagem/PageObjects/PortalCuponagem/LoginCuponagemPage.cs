using OpenQA.Selenium;
using System.Configuration;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System;
using System.Threading;

namespace AutomacaoCuponagem.PageObjects
{
    class LoginCuponagemPage
    {
        private IWebDriver driver;

        public LoginCuponagemPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Acessar Tela de Criar Promocao 
        public void AcessarURLLoginPage()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLBase"]);         
        }

        //Preencher Campos de Login - Estabelecimento Com Cadastro Prévio
        public void PreencherDados()
        {
            Thread.Sleep(500);
            driver.FindElement(By.Id("cnpj")).SendKeys(ConfigurationManager.AppSettings["CNPJ"]);
            driver.FindElement(By.Id("token")).SendKeys(ConfigurationManager.AppSettings["Token"]);
        }
        //Preencher Campos de Login - Estabelecimento Sem Cadastro Prévio
        public void PreencherDadosSemCad()
        {            
            Random rnd = new Random();
            int cnpj = rnd.Next(1000000, 9999999);

            Thread.Sleep(1000);
            driver.FindElement(By.Id("cnpj")).SendKeys("1234567" + cnpj);
            driver.FindElement(By.Id("token")).SendKeys("1234567"+ cnpj);
        }

        //Preencher Campos de Login - Estabelecimento Com Bloqueio
        public void PreencherDadosUsuarioBloqueado(string cnpj)
        {
            Thread.Sleep(500);
            driver.FindElement(By.Id("cnpj")).SendKeys(cnpj);
            driver.FindElement(By.Id("token")).SendKeys(cnpj);
        }

        //Clicar Botão Login
        public void ClicarBotaoEntrar()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("submit-button")).Click();
        }
    }
}

