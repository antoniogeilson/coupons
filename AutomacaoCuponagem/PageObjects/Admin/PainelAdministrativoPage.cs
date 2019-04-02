using OpenQA.Selenium;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;
using System;
using System.Configuration;

namespace AutomacaoCuponagem.PageObjects
{
    public class PainelAdministrativoPage
    {
        private IWebDriver driver;
        
        public PainelAdministrativoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Validar Tela de Alteração de Dados do EC
        public void AcessarPainelAdministrativo()
        {
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLPortalAdministrativo"]);        
        }

        //Preencher Campos de Login
        public void RealizarLogin()
        {
            //Preencher Campos de Login
            driver.FindElement(By.Id("user")).SendKeys(ConfigurationManager.AppSettings["AdminUsuario"]);
            driver.FindElement(By.Id("pass")).SendKeys(ConfigurationManager.AppSettings["AdminSenha"]);
            
            //Clivar no Botão Entrar
            driver.FindElement(By.Id("submit-auth")).Click();
        }
        
        //Acessar Menu Restrito 
        public void AcessarPainelAdministrativoRestrito()
        {
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLPortalAdministrativoRestrito"]);
        }

        //Bloquear CNPJ na Lista
        public void BloquearUsuario(string cnpj)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("block-"+cnpj)).Click();            
        }
        
    }
}
