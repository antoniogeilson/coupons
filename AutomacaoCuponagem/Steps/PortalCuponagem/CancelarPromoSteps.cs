using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Features
{
    [Binding]
    public class CancelarPromoSteps
    {        
        private IWebDriver driver;
        private PainelPromocoesPage painelPromocoesPage;
        private DetalhePromoPage detalhePromoPage;
        private LoginCuponagemPage loginCuponagemPage;

        public CancelarPromoSteps(IWebDriver driver)
        {
            this.driver = driver;
            painelPromocoesPage = new PainelPromocoesPage(driver);
            detalhePromoPage = new DetalhePromoPage(driver);
            loginCuponagemPage = new LoginCuponagemPage(driver);
        }

        [Given(@"acesso Detalhe da Promocao")]
        public void DadoAcessoDetalheDaPromocao()
        {
            painelPromocoesPage.ClicarPromoRecente();
        }
        
        [Given(@"visualizo os Detalhes da Promocao")]
        public void DadoVisualizoOsDetalhesDaPromocao()
        {
            detalhePromoPage.ValidarDetalhePromoCancelada();
        }
        
        [Given(@"pressiono Botao Cancelar Promocao")]
        public void DadoPressionoBotaoCancelarPromocao()
        {
            detalhePromoPage.CancelarPromoDetalhe();
        }
        
        [Given(@"visualizo Mensagem de Confirmacao de Cancelamento")]
        public void DadoVisualizoMensagemDeConfirmacaoDeCancelamento()
        {
            detalhePromoPage.ValidarDetalhePromoCancelada();
        }
        
        [When(@"pressiono Botao Cancelar Promocao \(Confirmacao\)")]
        public void QuandoPressionoBotaoCancelarPromocaoConfirmacao()
        {
            detalhePromoPage.ClicarBotaoCancelar();
        }
        
        [When(@"pressiono Botao Voltar\(Confirmacao\)")]
        public void QuandoPressionoBotaoVoltarConfirmacao()
        {
            detalhePromoPage.ClicarBotaoVoltar();
        }
        
        [Then(@"visualizo Mensagem de Confirmação")]
        public void EntaoVisualizoMensagemDeConfirmacao()
        {
            painelPromocoesPage.ValidarCancelamento();            
        }
        
        [Then(@"visualizo Promocao com Status Cancelada")]
        public void EntaoVisualizoPromocaoComStatusCancelada()
        {
            painelPromocoesPage.ValidarPromoStatusCancelada();
        }
        
        [Then(@"visualizo os Detalhes da Promocao")]
        public void EntaoVisualizoOsDetalhesDaPromocao()
        {
            detalhePromoPage.ValidarDetalhePromoCancelada();
        }
        
        [Then(@"visualizo Promocao com Status Ativa")]
        public void EntaoVisualizoPromocaoComStatusAtiva()
        {            
            detalhePromoPage.ConsultarPromoAtiva();
        }
    }
}
