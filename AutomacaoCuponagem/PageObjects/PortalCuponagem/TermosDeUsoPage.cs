using OpenQA.Selenium;
using System.Configuration;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;

namespace AutomacaoCuponagem.PageObjects
{
    class TermosDeUsoPage
    {
        private IWebDriver driver;

        public TermosDeUsoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //Validar Tela Termos de Uso e Clicar no botão Aceitar Termos de Uso
        public void ValidarTermosDeUso()
        {
            driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/div[2]/header/h1")).Text.Should().Contain("Termos de Uso");
            driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/div[2]/section[1]/article/h2")).Text.Should().Contain("TERMO DE CONTRATAÇÃO DO SERVIÇO DE CUPONAGEM");
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/section[2]/button")).GetAttribute("disabled");

            //Realiza o Pagedown buscando um elemento no ultimo parágrafo.
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/section[1]/article/p[32]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
        }
        //Clicar no botão Aceitar Termos de Uso
        public void ClicarBotaoTermosUso()
        {
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/section[2]/button")).Click();
        }
    }

}
    