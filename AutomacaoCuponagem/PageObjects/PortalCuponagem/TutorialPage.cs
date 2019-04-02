using OpenQA.Selenium;
using System.Configuration;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;

namespace AutomacaoCuponagem.PageObjects
{
    class TutorialPage
    {
        private IWebDriver driver;

        public TutorialPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        //Validar Tela Tutorial e Clicar no botão Proximo
        public void ValidarTutorial()
        {
            Thread.Sleep(500);
            driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/section[1]/div/div[1]/div/span")).Text.Should().Contain("Insira as informações do estabelecimento");
            driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/section[1]/div/div[2]/div/span")).Text.Should().Contain("Crie promoções para atrair consumidores");
            driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/section[1]/div/div[3]/div/span")).Text.Should().Contain("Acompanhe o sucesso dos cupons");
        }

        public void ClicarBotaoProximo()
        {
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/section[2]/form/a")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/section[2]/form/a")).Text.Should().Contain("Próximo");
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/section[2]/form/a")).Click();
        }

    }

}
