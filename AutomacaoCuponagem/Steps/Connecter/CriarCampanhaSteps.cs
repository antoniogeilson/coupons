using AutomacaoCuponagem.PageObjects.Connecter;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Steps.Connecter
{
    [Binding]
    public class CriarCampanhaSteps
    {
        private IWebDriver driver;
        private CriarCampanhaPage criarCampanhaPage;
        private ListaCampanhasPage listaCampanhasPage;
        private LoginConnecterPage loginConnecterPage;

        public CriarCampanhaSteps(IWebDriver driver)
        {
            this.driver = driver;
            criarCampanhaPage = new CriarCampanhaPage(driver);
            listaCampanhasPage = new ListaCampanhasPage(driver);
            loginConnecterPage = new LoginConnecterPage(driver);
        }
        
        [Given(@"visualizo a tela Tela de Lista de Campanhas No Connecter")]
        public void DadoVisualizoATelaTelaDeListaDeCampanhasNoConnecter()
        {
            loginConnecterPage.AcessarURLConnecter();
            loginConnecterPage.PreencherCamposLoginValido();
            loginConnecterPage.ClicarBotaoEntrar();
            listaCampanhasPage.ValidarListaCampanhas();
        }
        
        [Given(@"pressiono no botão Criar Campanha")]
        public void DadoPressionoNoBotaoCriarCampanha()
        {
            listaCampanhasPage.ClicarBotaoCriarCampanha();
        }

        [Given(@"visualizo a tela de Criar Campanha")]
        public void DadoVisualizoATelaDeCriarCampanha()
        {
            criarCampanhaPage.ValidarTelaCriarCampanha();
        }

        [Given(@"preencho os dados do Solicitante\(Porcentagem\) (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void DadoPreenchoOsDadosDoSolicitantePorcentagemRestauranteXYZLanchesBrasileiroPercentual
            (string nomeFantasia, string cnpjCentral, string tipoRestaurante, string tipoCozinha, string tipoPromocao, string valorPromocao)                      
        {
            criarCampanhaPage.PreencherDadosSolicitantePercentual
                (nomeFantasia, cnpjCentral, tipoRestaurante, tipoCozinha, tipoPromocao, valorPromocao);
        }

        [Given(@"preencho os dados do Solicitante\(Valor\) (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void DadoPreenchoOsDadosDoSolicitanteValorRestauranteDoPedroLanchesBrasileiroPercentual
           (string nomeFantasia, string cnpjCentral, string tipoRestaurante, string tipoCozinha, string tipoPromocao, string valorPromocao)
        {
            criarCampanhaPage.PreencherDadosSolicitanteValor
                (nomeFantasia, cnpjCentral, tipoRestaurante, tipoCozinha, tipoPromocao, valorPromocao);
        }

        [Given(@"preencho os dados do Solicitante\(Brinde\) (.*), (.*), (.*), (.*), (.*)")]
        public void DadoPreenchoOsDadosDoSolicitanteBrindeRestauranteAzulaoLanchesBrasileiroBrinde
            (string nomeFantasia, string cnpjCentral, string tipoRestaurante, string tipoCozinha, string tipoPromocao)
        {
            criarCampanhaPage.PreencherDadosSolicitanteBrinde
                 (nomeFantasia, cnpjCentral, tipoRestaurante, tipoCozinha, tipoPromocao);
        }
                
        [Given(@"realizo a importação das Lojas Participantes")]
        public void DadoRealizoAImportacaoDasLojasParticipantes()
        {
            criarCampanhaPage.ImportarLojasParticipantes();
            criarCampanhaPage.MSGImportacaoLojas();
        }
        
        [Given(@"realizo a importação dos CPFs Impactados")]
        public void DadoRealizoAImportacaoDosCPFsImpactados()
        {
            criarCampanhaPage.ImportarCPFsImpactados();
            criarCampanhaPage.MSGImportacaoCPFs();
        }
        
        [Given(@"realizo a importação da Arte da Promoção")]
        public void DadoRealizoAImportacaoDaArteDaPromocao()
        {
            criarCampanhaPage.ImportarImagemPromo();
            //criarCampanhaPage.MSGImportacaoImagem();
        }

        [When(@"pressiono botão Confirmar Campanha\(Desabilidado\)")]
        public void QuandoPressionoBotaoConfirmarCampanhaDesabilidado()
        {
            criarCampanhaPage.BotaoCampanhaDesabilidado();
        }

        [Then(@"visualizo Campos Dados do Solicitante Sem Preenchimento")]
        public void EntaoVisualizoCamposDadosDoSolicitanteSemPreenchimento()
        {
            criarCampanhaPage.DadosSolicitanteEmBranco();
        }
        
        [When(@"pressiono botão Confirmar Campanha")]
        public void QuandoPressionoBotaoConfirmarCampanha()
        {
            criarCampanhaPage.ConfirmarPromo();            
        }
        
        [Then(@"visualizo a Mensagem de Confirmacao\(Connecter\)")]
        public void EntaoVisualizoAMensagemDeConfirmacaoConnecter()
        {
            listaCampanhasPage.MSGCampanhaCriada();
        }
        
        [Then(@"Cupom de Porcentagem Criado no Connecter (.*), (.*)")]
        public void EntaoCupomDePorcentagemCriadoNoConnecterRestauranteXYZ(string tipoRestaurante, string valorPromocao)
        {
            listaCampanhasPage.ValidarDadosCampanhaPercentual(tipoRestaurante, valorPromocao);
        }

        [Then(@"Cupom de Desconto - Valor Criado no Connecter (.*), (.*)")]
        public void EntaoCupomDeDesconto_ValorCriadoNoConnecterRestauranteDoPedro(string tipoRestaurante, string valorPromocao)
        {
            listaCampanhasPage.ValidarDadosCampanhaValor(tipoRestaurante, valorPromocao);
        }

        [Then(@"Cupom de Brinde Criado no Connecter (.*)")]
        public void EntaoCupomDeBrindeCriadoNoConnecterRestauranteAzulao(string tipoRestaurante)
        {
            listaCampanhasPage.ValidarDadosCampanhaBrinde(tipoRestaurante);
        }

    }
}
