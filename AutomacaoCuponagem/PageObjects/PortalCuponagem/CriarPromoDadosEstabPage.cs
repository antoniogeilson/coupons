using OpenQA.Selenium;
using System.Configuration;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;

namespace AutomacaoCuponagem.PageObjects
{
    //Page Object da Tela de Criar Promoções - Dados do Estabelecimento
    class CriarPromoDadosEstabPage
    {
        private IWebDriver driver;

        public CriarPromoDadosEstabPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Acessar Tela de Criar Promocao 
        public void AcessarTelaCriarPromocao()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLCadPromo"]);
        }

        //Acessar Tela de Criar Promocao NEW 
        public void AcessarTelaCriarPromocaoNew()
        {
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLCadPromoNew"]);
        }

        //Preencher Campos Dados Mínimos Para Cadastro do Estabelecimento
        public void PreencherCamposEstabelecimento
            (string nomeFantasia, string cep, string numero, string complemento, string tipoEstabelecimento, string tipoCozinha)
                       
        {            
            driver.FindElement(By.Id("name")).SendKeys(nomeFantasia);
            driver.FindElement(By.Id("zipcode")).SendKeys(cep);
            driver.FindElement(By.Id("number")).SendKeys(numero);
            driver.FindElement(By.Id("complement")).SendKeys(complemento);
            driver.FindElement(By.Id("type")).SendKeys(tipoEstabelecimento);
            driver.FindElement(By.Id("cuisine")).SendKeys(tipoCozinha);
        }
        
        //Preencher Campos Para Ciades Com um Unico CEP 062170000
        public void PreencherCamposEstabelecimentoCepUnico
            (string nomeFantasia, string cep, string endereco, string bairro, string numero, string tipoEstabelecimento, string tipoCozinha)

        {
            driver.FindElement(By.Id("name")).SendKeys(nomeFantasia);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("zipcode")).SendKeys(cep);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("address")).SendKeys(endereco);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("number")).SendKeys(numero);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("neighborhood")).SendKeys(bairro);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("type")).SendKeys(tipoEstabelecimento);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cuisine")).SendKeys(tipoCozinha);
        }

        //Preencher Campo CEP com Valor Inválido
        public void PreencherCampoCEPValorInvalido (string cep)
        {
            driver.FindElement(By.Id("zipcode")).SendKeys(cep);
        }

        //Validar Mensagem CEP Não Encontrado
        public void MensagemCEPInvalido()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[1]")).Text.Should().Contain("CEP não encontrado");
        }

        //Clicar Botão Próximo Passo
        public void ClicarBotaoProximoPasso()
        {
            driver.WaitElement(By.Id("btn-create-promotion")).Click();
        }

        //Clicar Botão Cancelar
        public void ClicarBotaoCancelar()
        {
            driver.WaitElement(By.ClassName("secondary")).Click();
        }

        //Validar Tela Com Dados da Promocao (Pos Condicoes)
        public void ValidarTelaDadosDaPromocao()
        {
           Thread.Sleep(500);
           driver.WaitElement(By.XPath("//*[@id=\"content\"]/section/main/div/div[1]/div/div[1]/header/span/h1")).Text.Should().Contain("Criar Promoção");
        }
        
    }
}

