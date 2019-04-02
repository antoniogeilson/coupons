using OpenQA.Selenium;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;


namespace AutomacaoCuponagem.PageObjects
{
    //Page Object da Tela de Criar Promoções - Dados do Estabelecimento
    class CriarPromoDadosPromoPage
    {
        private IWebDriver driver;

        public CriarPromoDadosPromoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ValidarLoginOK()
        {
            driver.WaitElement(By.XPath("//*[@id=\"container\"]/header/section/a/h1")).Text.Should().Contain("Painel de Promoções");
        }
        
        //Preencher Dados da Promocao = Tipo de Desconto = Percentual => 10% e QTde = 25 Cupons
        public void PreencherTipoDescPercent(string percentual)
        {
            Thread.Sleep(1000);

            //Preencher Campos Tipo de Desconto, Valor da Promoção e Quantidade e Cupons
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[2]/form/fieldset[1]/div[1]/label[3]")).Click();
            driver.FindElement(By.Id("percent-value-field")).SendKeys(percentual);
            driver.FindElement(By.Id("submit-button")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[2]/form/fieldset[2]/div/label[1]")).Click();
         }

        //Preencher Dados da Promocao = Tipo de Desconto = Desconto => Valor = R$ 50,00 e QTde = 50 Cupons
        public void PreencherTipoDescValor(string valor)
        {
            Thread.Sleep(1000);

            //Preencher Campos Tipo de Desconto, Valor da Promoção e Quantidade e Cupons
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[2]/form/fieldset[1]/div[1]/label[2]")).Click();
            driver.FindElement(By.Id("discount-value-field")).SendKeys(valor);
            driver.FindElement(By.Id("submit-button")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[2]/form/fieldset[2]/div/label[2]")).Click();
         }
        //Preencher Dados da Promocao = Tipo de Desconto = Brinde Café e QTde = 75 Cupons
        public void PreencherTipoDescBrinde(string brinde)
        {
            Thread.Sleep(1000);

            //Preencher Campos Tipo de Desconto, Valor da Promoção e Quantidade e Cupons
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[2]/form/fieldset[1]/div[1]/label[1]")).Click();
            driver.FindElement(By.Id("gift-value-field")).SendKeys(brinde);
            driver.FindElement(By.Id("submit-button")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[2]/form/fieldset[2]/div/label[3]")).Click();
         }

        //Clicar Botão Confirmar
        public void ClicarBotaoProximoPasso()
        {
            driver.WaitElement(By.Id("submit-button")).Submit();
        }    

        //Validar Tela de Confirmação de Dados (Pos Condicoes)
        public void ValidarTelaDadosConfirmarDados()
        {
            Thread.Sleep(3000);
            driver.WaitElement(By.Id("creation-step")).Text.Should().Contain("3. Confirmar Dados");
        }

    }
}




