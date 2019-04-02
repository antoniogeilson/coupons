using OpenQA.Selenium;
using FluentAssertions;
using System.Threading;
using SeleniumWebdriverHelpers;

namespace AutomacaoCuponagem.PageObjects
{
    class DetalhePromoPage
    {
        private IWebDriver driver;
            
        public DetalhePromoPage (IWebDriver driver)
        {
            this.driver = driver;            
        }

        //Header Detalhes da Promoção
        public void ValidarDetalhePromoCancelada()
        {            
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/nav/ul/li[2]/span")).Text.Should().Contain("Detalhes da Promoção");            
        }

        //Clicar No Botão Cancelar Promoção (Tela de Detalhe da Promoção)
        public void CancelarPromoDetalhe()
        {
            Thread.Sleep(500);
            
            //Pagedown
            IWebElement element = driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[2]/div/form[1]/button"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
                                    
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[2]/div/form[1]/button")).Click();            
        }
        
        //Validar Mensagem De Cancelamento
        public void ValidarMensagemCancelamento()
        {
            Thread.Sleep(500);
            //Modal da Mensagem
            driver.FindElement(By.CssSelector("#container>div>div.content>div.modal-mask>div>div>div.modal-header>div>h2>span")).Text.Should().Contain("Tem certeza de que deseja finalizar a promoção?");

            //Botão - Voltar
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[5]/div/div/div[3]/button[2]")).Text.Should().Contain("Voltar");
            
            //Botão - Cancelar Promoção
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[5]/div/div/div[3]/button[1]")).Text.Should().Contain("Cancelar Promoção");
        }

        //Clicar Botão Cancelar Promoção (Mensagem de Confirmação)
        public void ClicarBotaoCancelar()
        {
            Thread.Sleep(500);            
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[5]/div/div/div[3]/button[1]")).Click();            
        }

        //Clicar Botão Cancelar Promoção (Mensagem de Confirmação)
        public void ClicarBotaoVoltar()
        {
            Thread.Sleep(500);            
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[5]/div/div/div[3]/button[2]")).Click();                              
        }

        //Consultar Promo Com Status Ativo
        public void ConsultarPromoAtiva()
        {            
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[1]/div/p")).Text.Should().Contain("Expira em");
        }

        //Consultar Promo Com Status Expirada
        public void ValidarDetalhePromoExpirada()
        {            
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[1]/div/p")).Text.Should().Contain("Expirada");
        }
                 
        //Clicar No Botão Relançar Promoção (Na Tela de Detalhe da Promoção)
        public void ClicarRelancarPromo()
        {
            Thread.Sleep(500);

            IWebElement element = driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[2]/div/form[2]/button"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[2]/div/form[2]/button")).Click();            
        }

        //Mensagem de Relançar Promo
        public void ValidarMensagemRelancar()
        {
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[5]/div/div/div[1]/div/h2")).Text.Should().Contain("Tem certeza de que deseja relançar a promoção?");
        }

        //Clicar no Botão Voltar (Mensagem de Confirmação)
        public void ClicarBotaoVoltarMensangemRelancar()
        {
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[5]/div/div/div[3]/button[2]")).Click();
        }

        //Clicar no Botão Relançar (Mensagem de Confirmação)
        public void ClicarRelancarMensangemRelancar()
        {
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div[5]/div/div/div[3]/button[1]")).Click();
        }

    }

}
