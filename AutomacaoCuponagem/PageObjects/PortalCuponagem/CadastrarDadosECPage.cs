using OpenQA.Selenium;
using FluentAssertions;
using System.Threading;

namespace AutomacaoCuponagem.PageObjects
{
    public class CadastrarDadosECPage
    {
        private IWebDriver driver;
        
        public CadastrarDadosECPage(IWebDriver driver)
        {
            this.driver = driver;
        }
                  
        public void ValidarCamposObrigatorios()
        {
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[1]")).Text.Should().Contain("Os campos abaixo são obrigatórios");
        }

        public void ClicarBotaoProsseguir()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("submit-button")).Click();
        }

        public void ValidarTelaCadastroEC()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[1]/h2")).Text.Should().Contain("Olá! Precisamos da sua identificação para criar a promoção.");            
        }

    }

}
