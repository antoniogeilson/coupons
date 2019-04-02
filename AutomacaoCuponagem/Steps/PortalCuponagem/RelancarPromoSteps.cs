using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Steps
{
    [Binding]
    public class RelancarPromocaoSteps
    {
        private IWebDriver driver;
        private LoginCuponagemPage loginCuponagemPage;
        private TutorialPage tutorialPage;
        private TermosDeUsoPage termosDeUsoPage;
        private CriarPromoDadosEstabPage criarPromoDadosEstabPage;
        private CriarPromoDadosPromoPage criarPromoDadosPromoPage;
        private CriarPromoConfirmarDadosPage criarPromoConfirmarDadosPage;
        private CadastrarDadosECPage cadastroDadosECPage;
        private PainelPromocoesPage painelPromocoesPage;
        private DetalhePromoPage detalhePromoPage;


        public RelancarPromocaoSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginCuponagemPage = new LoginCuponagemPage(driver);
            tutorialPage = new TutorialPage(driver);
            termosDeUsoPage = new TermosDeUsoPage(driver);
            criarPromoDadosEstabPage = new CriarPromoDadosEstabPage(driver);
            criarPromoConfirmarDadosPage = new CriarPromoConfirmarDadosPage(driver);
            cadastroDadosECPage = new CadastrarDadosECPage(driver);
            painelPromocoesPage = new PainelPromocoesPage(driver);
            criarPromoDadosPromoPage = new CriarPromoDadosPromoPage(driver);
            detalhePromoPage = new DetalhePromoPage(driver);
        }
             
        
        [Given(@"visualizo os Detalhes da Promocao Expirada")]
        public void DadoVisualizoOsDetalhesDaPromocaoExpirada()
        {
            detalhePromoPage.ValidarDetalhePromoExpirada();            
        }

        [Given(@"visualizo Mensagem de Confirmacao")]
        public void DadoVisualizoMensagemDeConfirmacao()
        {
            detalhePromoPage.ValidarMensagemRelancar();            
        }

        [Given(@"pressiono Botao Relancar Promocao")]
        public void DadoPressionoBotaoRelancarPromocao()
        {
            detalhePromoPage.ClicarRelancarPromo();
        }

        [Given(@"visualizo uma Promoção\(Porcentagem\) Expirada refrigerante")]
        public void DadoVisualizoUmaPromocaoPorcentagemExpiradaRefrigerante()
        {
            ScenarioContext.Current.Pending();
        }       

        [When(@"pressiono Botao Voltar\(Mensagem\)")]
        public void QuandoPressionoBotaoVoltarMensagem()
        {
            detalhePromoPage.ClicarBotaoVoltarMensangemRelancar();
        }
        
        [When(@"pressiono Botao Relancar Promocao \(Mensagem\)")]
        public void QuandoPressionoBotaoRelancarPromocaoMensagem()
        {
            detalhePromoPage.ClicarRelancarMensangemRelancar();
        }
        
        [Then(@"visualizo os Detalhes da Promocao Expirada")]
        public void EntaoVisualizoOsDetalhesDaPromocaoExpirada()
        {
            detalhePromoPage.ValidarDetalhePromoExpirada();            
        }
        
        [Then(@"visualizo Mensagem de Confirmacao")]
        public void EntaoVisualizoMensagemDeConfirmacao()
        {
            painelPromocoesPage.ValidarPromoRelancadaOK();
        }
        
        [Then(@"visualizo uma Promoção Relancada Ativa")]
        public void EntaoVisualizoUmaPromocaoRelancadaAtiva()
        {
            painelPromocoesPage.ValidarPromoStatusAtivo();            
        }
    }
}
