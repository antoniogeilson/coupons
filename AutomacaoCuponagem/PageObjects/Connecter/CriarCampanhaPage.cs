using OpenQA.Selenium;
using FluentAssertions;
using System.Threading;
using System.Configuration;
using SeleniumWebdriverHelpers;

namespace AutomacaoCuponagem.PageObjects.Connecter
{
    public class CriarCampanhaPage
    {
        private IWebDriver driver;

        public CriarCampanhaPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Acessar URL do Connecter - Criar Promoção
        public void AcessarURLConnecter()
        {
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLConnecterNew"]);
        }

        //Validar Tela Criar Campanhas - Dados do Solicitante
        public void ValidarTelaCriarCampanha()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[3]/div/div[1]/h3/span")).Text.Should().Contain("Dados do Solicitante");
            driver.FindElement(By.XPath("//*[@id=\"ec-importer\"]/h3/span")).Text.Should().Contain("Lojas Participantes");
            driver.FindElement(By.XPath("//*[@id=\"customers-importer\"]/h3/span")).Text.Should().Contain("CPFs Impactados");
            driver.FindElement(By.XPath("//*[@id=\"image-importer\"]/h3/span")).Text.Should().Contain("Arte da Promoção");
        }

        //Preencher Campos - Dados do Solicitante - Percentual
        public void PreencherDadosSolicitantePercentual
            (string nomeFantasia, string cnpjCentral, string tipoRestaurante, string tipoCozinha, string tipoPromocao, string valorPromocao)
        {
            Thread.Sleep(2000);            
            driver.FindElement(By.Id("name")).SendKeys(nomeFantasia);
            driver.FindElement(By.Id("cnpj")).SendKeys(cnpjCentral);
            driver.FindElement(By.Id("type")).SendKeys(tipoRestaurante);
            driver.FindElement(By.Id("cuisine")).SendKeys(tipoCozinha);
            driver.FindElement(By.Id("promotion-type")).SendKeys(tipoPromocao);
            driver.FindElement(By.Id("percent-value-field")).SendKeys(valorPromocao);            
        }

        //Preencher Campos - Dados do Solicitante - Valor
        public void PreencherDadosSolicitanteValor
            (string nomeFantasia, string cnpjCentral, string tipoRestaurante, string tipoCozinha, string tipoPromocao, string valorPromocao)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("name")).SendKeys(nomeFantasia);
            driver.FindElement(By.Id("cnpj")).SendKeys(cnpjCentral);
            driver.FindElement(By.Id("type")).SendKeys(tipoRestaurante);
            driver.FindElement(By.Id("cuisine")).SendKeys(tipoCozinha);
            driver.FindElement(By.Id("promotion-type")).SendKeys(tipoPromocao);
            driver.FindElement(By.Id("discount-value-field")).SendKeys(valorPromocao);
        }

        //Preencher Campos - Dados do Solicitante - Brinde
        public void PreencherDadosSolicitanteBrinde
            (string nomeFantasia, string cnpjCentral, string tipoRestaurante, string tipoCozinha, string tipoPromocao)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("name")).SendKeys(nomeFantasia);
            driver.FindElement(By.Id("cnpj")).SendKeys(cnpjCentral);
            driver.FindElement(By.Id("type")).SendKeys(tipoRestaurante);
            driver.FindElement(By.Id("cuisine")).SendKeys(tipoCozinha);
            driver.FindElement(By.Id("promotion-type")).SendKeys(tipoPromocao);
        }

        //---------------------------------------//
        //-- Mensagens da Tela Criar Promoções --//
        //---------------------------------------//

        //Pegar o Elemento da Mensagem de Confirmação de Importação
        public string PegarElementoMSGImportacao()
        {
            var msgElement = driver.WaitElement(By.XPath("//*[@id=\"container\"]/div/div[2]")).GetText();
            return msgElement;
        }

        //Mensagem de Confirmação Para Importação de Planilha de Participantes
        public void MSGImportacaoLojas()
        {
            //Thread.Sleep(3000);
            var msgElement = PegarElementoMSGImportacao();
            msgElement.Should().Contain("1 lojas importadas com sucesso");
        }

        //Mensagem de Confirmação Para Importação de Planilha de CPFs Impactados
        public void MSGImportacaoCPFs()
        {
            //Thread.Sleep(2000);
            var msgElement = PegarElementoMSGImportacao();
            msgElement.Should().Contain("12 CPFs importados com sucesso");
        }

        //Mensagem de Confirmação Para Importação da Imagem da Promoção
        public void MSGImportacaoImagem()
        {
            Thread.Sleep(1000);
            var msgElement = PegarElementoMSGImportacao();
            msgElement.Should().Contain("Imagem importada com sucesso");
        }
        
        //---------------------------------------//
        //------- Importaçao de Arquivos --------//
        //---------------------------------------//

        //importar planilha de Lojas Participantes
        public void ImportarLojasParticipantes()
        {

            //elemento File que receberá a planilha - Informar Caminho da Planiha via Sendkeys
            driver.FindElement(By.XPath("//*[@id=\"ec-importer\"]/input")).SendKeys("C:\\Users\\Antonio Geilson\\Desktop\\Cuponagem_V2\\Arquivos_Connecter\\01-companies.csv");
            Thread.Sleep(3000);                      
        }
        
        //importar planilha de CPFs
        public void ImportarCPFsImpactados()
        {
                
            //elemento File que receberá a planilha - Informar Caminho da Planiha via Sendkeys
            driver.FindElement(By.XPath("//*[@id=\"customers-importer\"]/input")).SendKeys("C:\\Users\\Antonio Geilson\\Desktop\\Cuponagem_V2\\Arquivos_Connecter\\02-customers.csv");
            Thread.Sleep(3000);
        }

        //importar Imagem da Promoção
        public void ImportarImagemPromo()
        {

            //elemento File que receberá a imagem - Informar Caminho da imagem via Sendkeys
            driver.FindElement(By.XPath("//*[@id=\"image-importer\"]/input")).SendKeys("C:\\Users\\Antonio Geilson\\Desktop\\Cuponagem_V2\\Arquivos_Connecter\\03-campaign.jpg");
            Thread.Sleep(3000);
        }        

        //Clicar No Botão Confirmar Campanha
        public void ConfirmarPromo()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("submit-campaign")).Click();
        }
        
        //Validar Botão Confirmar Campanha Desabilitado
        public void BotaoCampanhaDesabilidado()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("submit-campaign")).GetAttribute("disabled").Should().BeEquivalentTo("true");
        }

        //Validar Campos Dados do Solicitante Não Preenchidos
        public void DadosSolicitanteEmBranco()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("name")).GetAttribute("placeholder").Should().Contain("Nome Fantasia do Restaurante");
            driver.FindElement(By.Id("cnpj")).GetAttribute("placeholder").Should().Contain("CNPJ Central (Solicitante da Promoção)");
            driver.FindElement(By.Id("base-type")).Text.Should().Contain("Tipo de Restaurante");
            driver.FindElement(By.Id("cuisine")).GetAttribute("disabled").Should().BeEquivalentTo("true");
            driver.FindElement(By.Id("promotion-type")).Text.Should().Contain("Tipo de Promoção");
        }


    }
}
