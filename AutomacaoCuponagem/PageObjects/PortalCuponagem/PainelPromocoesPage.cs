using OpenQA.Selenium;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomacaoCuponagem.PageObjects
{
    public class PainelPromocoesPage
    {
        private IWebDriver driver;

        public PainelPromocoesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Botão Criar Promoções - Para EC Sem Promoções Existentes
        public void ClicarBotaoCriarPromocao_ECSemPromo()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/a")).Click();
        }

        //Botão Criar Promoções - Para EC Com Promoções Existentes.
        public void ClicarBotaoCriarPromocao_ECComPromo()
        {           
            try
            {
                driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/header/a")).Click();                                
            }
            catch (System.Exception)
            {
                driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/a")).Click();                
            }            
        }

        //Acessar Opção Criar Promoções - VIA URL
        public void AcessarURLNovaPromocao()
        {
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLCadPromoNew"]);
        }

        //Acessar Opção Cadastrar EC - VIA URL
        public void AcessarURLCadastrarDadosEC()
        {
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLCadEC"]);
        }

        //Acessar Opção Alterar EC - VIA URL
        public void AcessarURLAlterarDadosEC()
        {
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLAltEC"]);
        }

        //Acessar Opção Alterar EC - VIA Botão
        public void ClicarBotaoAlterarDadosEC()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("edit-company-link")).Click();
        }


        //Valida Login Com Sucesso
        public void ValidarLoginOK()
        {
            driver.WaitElement(By.XPath("//*[@id=\"container\"]/header/section/a/h1")).Text.Should().Contain("Painel de Promoções");
        }

        //Pega o Elemento Que Exibe Às Mensagens Após Cada Operação
        public string PegarElementoMensagem()
        {
            var msgElement = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]")).GetText();
            return msgElement;
        }

        //Valida Mensagem de Promoção Cadastrada com Sucesso
        public void ValidarPromoOk()
        {
            Thread.Sleep(1000);
            var validarMsg = PegarElementoMensagem();
            validarMsg.Should().Contain("Promoção preenchida com sucesso");                       
        }

        //Valida Mensagem de Promoção Relançada com Sucesso
        public void ValidarPromoRelancadaOK()
        {
            Thread.Sleep(1000);
            var validarMsg = PegarElementoMensagem();
            validarMsg.Should().Contain("Promoção relançada com sucesso");            
        }

        //Valida Mensagem de Promoção Cancelada com Sucesso
        public void ValidarCancelamento()
        {
            Thread.Sleep(1000);
            var validarMsg = PegarElementoMensagem();
            validarMsg.Should().Contain("Promoção cancelada com sucesso");
        }

        //Valida Mensagem de Alteração de Dados do EC com Sucesso
        public void ValidarMsgECAlterado()
        {
            Thread.Sleep(2000);
            var validarMsg = PegarElementoMensagem();
            validarMsg.Should().Contain("Cadastro alterado com sucesso");
        }

        //Valida Mensagem de Usuario Bloqueado
        public void ValidarMsgECBloqueado()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]")).Text.Should().Contain("Desculpe, você não pode criar promoções no momento.");
        }

        //Validar Campo Criar Promoção Desabilitado
        public void ValidarBotaoDesabilitado()
        {
            Thread.Sleep(2000);
            var x = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/header/a")).GetAttribute("disabled");
            x.ShouldBeEquivalentTo(true);
        }
        
        //Acessar Última Promoção Mais Recente
        public void ClicarPromoRecente()
        {
            Thread.Sleep(1000);
            //Pegar Trecho do Hhref do elemento
            var url = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/ul/li[1]/div/a")).GetAttribute("href");
                       
            //Acessar URL Com Detalhe da Promoção
            driver.Navigate().GoToUrl(url);
        }
        
        //Pegar Trecho do Href do elemento => Para Reserva de Cupons
        public string PegarUrlCupom()
        {            
            try
            {
                var url = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/ul/li[1]/div/a")).GetAttribute("href");
                var position = url.LastIndexOf('/');
                var promoCode = url.Substring(position + 1, url.Length - position - 1);
                Thread.Sleep(1000);
                return promoCode;
            }
            catch
            {
                return "";
            }            
        }    
               
        //Consultar Última Promo Com Status Cancelada
        public void ValidarPromoStatusCancelada()
        {
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/ul/li[1]/div/a/div[2]/p")).Text.Should().Contain("Cancelada");
        }

        //Pegar Elemento Referente ao Primeiro Registro Na Tela Painel de Promoções
        public string PegarPrimeiroRegistroPainelPromo()
        {
            var promoElement = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/ul/li[(1)]")).GetText();
            return promoElement;
        }

        //Consultar Última Promo Com Status Ativo
        public void ValidarPromoStatusAtivo()
        {
            Thread.Sleep(1000);
            var promoElement = PegarPrimeiroRegistroPainelPromo();
            promoElement.Should().Contain("Expira em");
        }

        //Consultar Última Promo Com Status Ativo
        public void ValidarPromoStatusExpirada()
        {
            Thread.Sleep(2000);
            var promoElement = PegarPrimeiroRegistroPainelPromo();
            promoElement.Should().Contain("Expirada");
        }
                
        //Valida o Cupom - Percentual Na Lista
        public void ValidarPromoPercentual(string percentual)
        {
            Thread.Sleep(2000);
            var promoElement = PegarPrimeiroRegistroPainelPromo();
            promoElement.Should().Contain(percentual + "% de desconto");
        }

        //Valida o Cupom - Valor Na Lista
        public void ValidarPromoValor(string valor)
        {
            Thread.Sleep(2000);
            var promoElement = PegarPrimeiroRegistroPainelPromo();
            promoElement.Should().Contain("R$ "+ valor + ",00");
        }

        //Valida o Cupom - Brinde Na Lista
        public void ValidarPromoBrinde(string brinde)
        {
            Thread.Sleep(2000);
            var promoElement = PegarPrimeiroRegistroPainelPromo();
            promoElement.Should().Contain(brinde);
        }
        
    }
}
