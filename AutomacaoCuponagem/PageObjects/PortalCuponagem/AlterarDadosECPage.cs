using OpenQA.Selenium;
using FluentAssertions;
using SeleniumWebdriverHelpers;
using System.Threading;
using System;

namespace AutomacaoCuponagem.PageObjects
{
    public class AlterarDadosECPage
    {
        private IWebDriver driver;


        public AlterarDadosECPage(IWebDriver driver)
        {
            this.driver = driver;
        }
                
        //Validar Tela de Alteração de Dados do EC
        public void ValidarTelaAlterarDadosEC()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[2]/div[1]/h2")).Text.Should().Contain("O novo endereço valerá apenas para novas promoções");
        }

        //Limpar Campos da Tela
        public void LimparCamposAlterarDadosEC()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("name")).ClearText();
            driver.FindElement(By.Id("number")).ClearText();
            driver.FindElement(By.Id("zipcode")).ClearText();
        }

        //Clicar no Botão Salvar
        public void ClicarBotaoSalvar()
        {
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("/html/body/div/div/footer"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

            Thread.Sleep(2000);
            driver.FindElement(By.Id("submit-button")).Submit();                       
        }

        //Mensagem de Campos Obrigatórios
        public void MsgCamposObrigatorios()
        {
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/div[1]")).Text.Should().Contain("Os campos abaixo são obrigatórios");
        }

        //Altera Número na Tela de Alteração de EC/
        public String AtualizarNumero()
        {
            Thread.Sleep(1000);
            var i = driver.FindElement(By.Id("number")).GetAttribute("value");            
            if (i == "123")
            {
                i = "456";
                driver.FindElement(By.Id("number")).Clear();
                driver.FindElement(By.Id("number")).SendKeys(i);
                return i;
            }
            else
            {
                i = "123";
                driver.FindElement(By.Id("number")).Clear();
                driver.FindElement(By.Id("number")).SendKeys(i);
            }
            return i;
        }
        //Guadar Numero Atualizado Para Validação Posterior
        public string GuardarNumeroAtualizado()
        {
            var num = driver.FindElement(By.Id("number")).GetAttribute("Value");
            return num;
        }
        
        //Altera CEP na Tela de Alteração de EC
        public string AtualizarCEP()
        {
            Thread.Sleep(1000);
           var i = driver.FindElement(By.Id("zipcode")).GetAttribute("value");

            if (i == "01010-010")
            {
                i = "02020-020";
                driver.FindElement(By.Id("zipcode")).Clear();
                driver.FindElement(By.Id("zipcode")).SendKeys(i);
            }
            else
            {
                i = "01010-010";
                driver.FindElement(By.Id("zipcode")).Clear();
                driver.FindElement(By.Id("zipcode")).SendKeys(i);
            }
            return i;
        }

        //Guadar CEP Atualizado Para Validação Posterior
        public string GuardarCEPAtualizado()
        {
            var cep = AtualizarCEP();
            //var cep = driver.FindElement(By.Id("zipcode")).GetAttribute("Value");
            return cep;
        }

        //Altera Restaurante na Tela de Alteração de EC
        public string AtualizarRestaurante()
        {
            Thread.Sleep(1000);
            var i = driver.FindElement(By.Id("type")).GetAttribute("value");
            if (i == "lanches")
            {
                i = "prato_feito";
                driver.FindElement(By.Id("type")).SendKeys(i);
            }
            else
            {
                i = "lanches";
                driver.FindElement(By.Id("type")).SendKeys(i);            
            }
            return i;
        }

        //Guadar Tipo Restaurante Atualizado Para Validação Posterior
        public string GuardarRestauranteAtualizado()
        {
            //var rest = driver.FindElement(By.Id("type")).GetAttribute("Value");
            var rest = AtualizarRestaurante();
            return rest;
        }

        //Altera Tipo de Cozinha na Tela de Alteração de EC
        public string AtualizarCozinha()
        {
            Thread.Sleep(1500);
            var i = driver.FindElement(By.Id("cuisine")).GetAttribute("value");
            if (i == "brasileiro")
            {
                i = "vegetariano";
                driver.FindElement(By.Id("cuisine")).SendKeys(i);
            }            
            else
            {
                i = "brasileiro";
                driver.FindElement(By.Id("cuisine")).SendKeys(i);
            }
            return i;
        }
        //Guarda Valor Atualizado do Método Atualizar Cozinha Para Validar Posteriormente. 
        public string GuardarCozinhaAtualizado()
        {
            var num = driver.FindElement(By.Id("cuisine")).GetAttribute("Value");
            return num;
        }
                
        //Valida Dados Alterados
        public void ValidarDadosECAlterado()
        {
            Thread.Sleep(1000);
            var numero = GuardarNumeroAtualizado();
            var cep = GuardarCEPAtualizado();
            var tipoRestaurante = GuardarRestauranteAtualizado();
            var tipoCozinha = GuardarCozinhaAtualizado();
            
            driver.FindElement(By.Id("number")).Text.Should().Contain(numero);
            driver.FindElement(By.Id("zipcode")).Text.Should().Contain(cep);
            driver.FindElement(By.Id("type")).Text.Should().Contain(tipoRestaurante);
            driver.FindElement(By.Id("cuisine")).Text.Should().Contain(tipoCozinha);            
        }

    }
}
