using OpenQA.Selenium;
using FluentAssertions;
using System.Threading;
using SeleniumWebdriverHelpers;

namespace AutomacaoCuponagem.PageObjects
{
    class CriarPromoConfirmarDadosPage
    {
        private IWebDriver driver;
        private CriarPromoDadosEstabPage criarPromoDadosEstabPage;      

        public CriarPromoConfirmarDadosPage(IWebDriver driver)
        {
            this.driver = driver;
            criarPromoDadosEstabPage = new CriarPromoDadosEstabPage(driver);
        }

        //Pega Valor do Elemento Header da Tela de Confirmar Dados
        public string PegarElementoConfirmarDados()
        {
            var elementoTipoPromo = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[2]/div/h2")).GetText();
            return elementoTipoPromo;
        }
        
        // Validar Percentual Na Tela de Confirmar Dados
        public void ConfirmarDadosPercentual(string percentual)
        {
            Thread.Sleep(2000);
            var elementoTipoPromo = PegarElementoConfirmarDados();
            elementoTipoPromo.Should().Contain(percentual + "% de desconto");
        }

        // Validar Valor Na Tela de Confirmar Dados
        public void ConfirmarDadosValor(string valor)
        {
            Thread.Sleep(2000);
            var elementoTipoPromo = PegarElementoConfirmarDados();
            elementoTipoPromo.Should().Contain("R$ " + valor + ",00");
        }

        // Validar Brinde Na Tela de Confirmar Dados
        public void ConfirmarDadosBrinde(string brinde)
        {
            Thread.Sleep(2000);
            var elementoTipoPromo = PegarElementoConfirmarDados();
            elementoTipoPromo.Should().Contain(brinde);
        }
        
        //Método Utilizado Para os Testes CadastrarDadosDoECFeature
        public void ConfirmarDados
            (string nomeFantasia, string tipoEstabelecimento, string tipoCozinha)
        {
            IWebElement element = driver.WaitElement(By.XPath("/html/body/div/div/footer"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

            Thread.Sleep(500);

            driver.FindElement(By.XPath("//*[@id=\"company_name\"]")).Text.Should().Contain(nomeFantasia);
            driver.FindElement(By.XPath("//*[@id=\"company_type\"]")).Text.Should().Contain(tipoEstabelecimento);
            driver.FindElement(By.XPath("//*[@id=\"cuisine\"]")).Text.Should().Contain(tipoCozinha);            
        }

        //Pegar Quantidade de Cupons da Promo
        public int PegarQtdeCupom()
        {            
            Thread.Sleep(2000);
            var url = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[4]/div/div/ul/li[1]/div/a")).GetAttribute("href");
            driver.Navigate().GoToUrl(url);

            Thread.Sleep(2000);
            var x = driver.WaitElement(By.Id("coupon_limit")).Text;
            int qtdCupons;
            
            if (x == "Até 25")
            {
                qtdCupons = 25;
                return qtdCupons;
            }
            if (x == "Até 50")
            {
                qtdCupons = 50;
                return qtdCupons;
            }
            if (x == "Até 75")
            {
                qtdCupons = 75;
                return qtdCupons;
            }
            else
            {
                return 1;
            }
        }
        
        //Clicar no Botão de Criar Promo
        public void ClicarBotaoCriarPromocao()
        {
            Thread.Sleep(2000);
            //IWebElement element = driver.FindElement(By.XPath("/html/body/div/div/footer"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div/div/div[4]/button")).Click();            
        }
    }
}

