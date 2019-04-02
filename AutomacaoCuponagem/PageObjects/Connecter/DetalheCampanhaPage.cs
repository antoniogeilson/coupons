using OpenQA.Selenium;
using FluentAssertions;
using System.Threading;
using System.Configuration;
using SeleniumWebdriverHelpers;

namespace AutomacaoCuponagem.PageObjects.Connecter
{
    public class DetalheCampanhaPage
    {
        private IWebDriver driver;

        public DetalheCampanhaPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        //Validar Tela Detalhe da Campanhas
        public void ValidarTelaDetalheCampanha(string nomeFantasia)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/header/section/div[1]/nav/ul/li[2]/span")).Text.Should().Contain(nomeFantasia);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div[1]/h3")).Text.Should().Contain("Dados do Solicitante");
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div[2]/h3/span")).Text.Should().Contain("Arte da Promoção");
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/header/section/div[2]/form/button")).Text.Should().Contain("Cancelar Campanha");
        }

        //Clicar No Botão Cancelar Campanha
        public void CancelarCampanha()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/header/section/div[2]/form/button")).Click();
        }
                
        //Validar Mensagem de Confirmação de Cancelamento 
        public void MensagemCancelamentoCampanha()
        {
            Thread.Sleep(2000);

            //Titulo da Mensagem
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div/div/div[1]/div/span")).Text.Should().Contain("Confirme o cancelamento");

            //Texto da Mensagem
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div/div/div[2]/p")).Text.Should().Contain("Confirmada essa opção a campanha e a divulgação das promoções serão interrompidas. Os cupons que foram anteriormente reservados pelos clientes continuarão disponíveis para a utilização nos estabelecimentos.");

            //Botões da Mensagem           
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div/div/div[3]/button[2]")).Text.Should().Contain("Voltar");
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div/div/div[3]/button[1]")).Text.Should().Contain("Confirmar");
        }
        
        //Clicar No Botão Voltar (Mensagem de Cancelamento)
        public void ClicarBotaoVoltar()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div/div/div[3]/button[2]")).Click();
        }
        
        //Clicar No Botão Confirmar (Mensagem de Cancelamento)
        public void ClicarBotaoConfirmar()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div/div/div[3]/button[1]")).Click();
        }

        //Retornar Para Tela Validar Tela Detalhe da Campanhas
        public void RetornarTelaDetalheCampanha()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div[1]/h3")).Text.Should().Contain("Dados do Solicitante");
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/header/section/div[2]/form/button")).Text.Should().Contain("Cancelar Campanha");
        }

    }
}
