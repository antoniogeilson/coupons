using OpenQA.Selenium;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;
using System.Configuration;

namespace AutomacaoCuponagem.PageObjects.Connecter
{
    public class ListaCampanhasPage
    {
        private IWebDriver driver;

        public ListaCampanhasPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Validar Tela Lista de Campanhas
        public void ValidarListaCampanhas()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/header/section/div[1]/nav/ul/li/a")).Text.Should().Contain("Lista de Campanhas");
        }

        //Clicar No Botão Criar Campanha
        public void ClicarBotaoCriarCampanha()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/header/section/div[2]/a")).Click();
        }

        //Pegar Valor do Elemento de Mensagem 
        public string PegarElementoMensagem()
        {
            //Thread.Sleep(1000);
            var msgElement = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[1]")).GetText();
            return msgElement;
        }
        //*[@id="container"]/div/div[1]

        //Validar Mensagem de Campanha Criada
        public void MSGCampanhaCriada()
        {
            Thread.Sleep(2000);
            var msgElement = PegarElementoMensagem();
            msgElement.Should().Contain("Campanha criada com sucesso");
        }

        //Validar Mensagem de Campanha Cancelada
        public void MSGCampanhaCancelada()
        {
            Thread.Sleep(2000);
            var msgElement = PegarElementoMensagem();
            msgElement.Should().Contain("Campanha cancelada com sucesso");
        }

        //Clicar No Elemento da Campanha Mais Recente
        public void ClicarCampanhaRecente()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/ul/li[1]")).Click();            
        }        

        //Pegar Valor do Elemento da Campanha Mais Recente
        public string PegarElementoCampanha()
        {
            Thread.Sleep(3000);
            var itemElement = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/ul/li[1]")).GetText();
            return itemElement;
        }
        
        //Validar o Elemento Mais Recente Com Dados Referente à Porcentagem
        public void ValidarDadosCampanhaPercentual(string tipoRestaurante, string valorPromocao)
        {
            Thread.Sleep(3000);
            var itemElement = PegarElementoCampanha();
            itemElement.Should().Contain(tipoRestaurante, valorPromocao + "%" + " de desconto");
        }
        
        //Validar o Elemento Mais Recente Com Status Ativo
        public void ValidarCampanhaAtiva()
        {
            Thread.Sleep(3000);
            var itemElement = PegarElementoCampanha();
            itemElement.Should().Contain("Expira em 30 dias");
        }

        //Validar o Elemento Mais Recente Com Status Cancelada
        public void ValidarCampanhaCancelada()
        {
            Thread.Sleep(3000);
            var itemElement = PegarElementoCampanha();
            itemElement.Should().Contain("Cancelada");
        }
        
        //Validar o Elemento Mais Recente Com Dados Referente à Valor
        public void ValidarDadosCampanhaValor(string tipoRestaurante, string valorPromocao)
        {
            Thread.Sleep(3000);
            var itemElement = PegarElementoCampanha();
            itemElement.Should().Contain(tipoRestaurante, "R$"+ valorPromocao + ",00");
        }

        //Validar o Elemento Mais Recente Com Dados Referente à Brinde
        public void ValidarDadosCampanhaBrinde(string tipoRestaurante)
        {
            Thread.Sleep(3000);
            var itemElement = PegarElementoCampanha();
            itemElement.Should().Contain(tipoRestaurante);
        }
        
    }
}
