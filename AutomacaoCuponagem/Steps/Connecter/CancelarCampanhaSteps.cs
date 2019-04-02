using AutomacaoCuponagem.PageObjects.Connecter;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Steps.Connecter
{
    [Binding]
    public class CancelarCampanhaSteps
    {
        private IWebDriver driver;
        private CriarCampanhaPage criarCampanhaPage;
        private ListaCampanhasPage listaCampanhasPage;
        private LoginConnecterPage loginConnecterPage;
        private DetalheCampanhaPage detalheCampanhaPage;
        
        public CancelarCampanhaSteps(IWebDriver driver)
        {
            this.driver = driver;
            criarCampanhaPage = new CriarCampanhaPage(driver);
            listaCampanhasPage = new ListaCampanhasPage(driver);
            loginConnecterPage = new LoginConnecterPage(driver);
            detalheCampanhaPage = new DetalheCampanhaPage(driver);
        }

        [Given(@"visualizo a tela Painel de Campanhas")]
        public void DadoVisualizoATelaPainelDeCampanhas()
        {
            loginConnecterPage.AcessarURLConnecter();
            loginConnecterPage.PreencherCamposLoginValido();
            loginConnecterPage.ClicarBotaoEntrar();
            listaCampanhasPage.ValidarListaCampanhas();            
        }
                
        [Given(@"crio uma Campanha para Cancelamento (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void DadoCrioUmaCampanhaParaCancelamento
            (string nomeFantasia, string cnpjCentral, string tipoRestaurante, string tipoCozinha, string tipoPromocao, string valorPromocao)
        {
            listaCampanhasPage.ClicarBotaoCriarCampanha();
            criarCampanhaPage.PreencherDadosSolicitantePercentual(nomeFantasia, cnpjCentral, tipoRestaurante, tipoCozinha, tipoPromocao, valorPromocao);
            criarCampanhaPage.ImportarLojasParticipantes();
            criarCampanhaPage.ImportarCPFsImpactados();
            criarCampanhaPage.ImportarImagemPromo();
            criarCampanhaPage.ConfirmarPromo();
        }

        [Given(@"visualizo uma Campanha Ativa (.*), (.*)")]
        public void DadoVisualizoUmaCampanhaAtiva(string tipoRestaurante, string valorPromocao)
        {
            listaCampanhasPage.ValidarDadosCampanhaPercentual(tipoRestaurante, valorPromocao);
        }      
        
        [Given(@"acesso Detalhe da Campanha")]
        public void DadoAcessoDetalheDaCampanha()
        {
            listaCampanhasPage.ClicarCampanhaRecente();            
        }

        [Given(@"visualizo os Detalhes da Campanha (.*)")]
        public void DadoVisualizoOsDetalhesDaCampanhaRestauranteXYZ(string nomeRestaurante)
        {
            detalheCampanhaPage.ValidarTelaDetalheCampanha(nomeRestaurante);
        }       

        [Given(@"pressiono Botao Cancelar Campanha")]
        public void DadoPressionoBotaoCancelarCampanha()
        {
            detalheCampanhaPage.CancelarCampanha();   
        }
        
        [Given(@"visualizo Mensagem de Confirmacao de Cancelamento de Campanha")]
        public void DadoVisualizoMensagemDeConfirmacaoDeCancelamentoDeCampanha()
        {
            detalheCampanhaPage.MensagemCancelamentoCampanha();
        }
        
        [When(@"pressiono Botao Voltar\(Campanha\)")]
        public void QuandoPressionoBotaoVoltarCampanha()
        {
            detalheCampanhaPage.ClicarBotaoVoltar();
        }
        
        [Then(@"visualizo os Detalhes da Campanha")]
        public void EntaoVisualizoOsDetalhesDaCampanha()
        {
            detalheCampanhaPage.RetornarTelaDetalheCampanha();
        }
        
        [Then(@"visualizo Detalhe da Campanha Ativa")]
        public void EntaoVisualizoDetalheDaCampanhaAtiva()
        {
            detalheCampanhaPage.RetornarTelaDetalheCampanha();
        }

        [When(@"pressiono Botao Confirmar\(Campanha\)")]
        public void QuandoPressionoBotaoConfirmarCampanha()
        {
            detalheCampanhaPage.ClicarBotaoConfirmar();
        }

        [Then(@"Mensagem de Cancelamento de Campanha Com Sucesso")]
        public void EntaoMensagemDeCancelamentoDeCampanhaComSucesso()
        {
            listaCampanhasPage.MSGCampanhaCancelada();            
        }

        [Then(@"visualizo Detalhe da Campanha Cancelada")]
        public void EntaoVisualizoDetalheDaCampanhaCancelada()
        {
            listaCampanhasPage.ValidarCampanhaCancelada();
        }
        
    }
}
