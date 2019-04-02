using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Steps
{
    [Binding]
    public class CadastrarDadosECSteps
    {
        private IWebDriver driver;
        private LoginCuponagemPage loginCuponagemPage;
        private TutorialPage tutorialPage;
        private TermosDeUsoPage termosDeUsoPage;
        private CriarPromoDadosEstabPage criarPromoDadosEstabPage;
        private CriarPromoConfirmarDadosPage criarPromoConfirmarDadosPage;
        private CadastrarDadosECPage cadastroDadosECPage;
        private PainelPromocoesPage painelPromocoesPage;

        public CadastrarDadosECSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginCuponagemPage = new LoginCuponagemPage(driver);
            tutorialPage = new TutorialPage(driver);
            termosDeUsoPage = new TermosDeUsoPage(driver);
            criarPromoDadosEstabPage = new CriarPromoDadosEstabPage(driver);
            criarPromoConfirmarDadosPage = new CriarPromoConfirmarDadosPage(driver);
            cadastroDadosECPage = new CadastrarDadosECPage(driver);
            painelPromocoesPage = new PainelPromocoesPage(driver);
        }
        // DADO_E

        [Given(@"que faço o login com EC Sem Cadastro do Estabelecimento")]
        public void DadoQueFacoOLoginComECSemCadastroDoEstabelecimento()
        {
            loginCuponagemPage.AcessarURLLoginPage();
            loginCuponagemPage.PreencherDadosSemCad();
            loginCuponagemPage.ClicarBotaoEntrar();
            tutorialPage.ValidarTutorial();
            tutorialPage.ClicarBotaoProximo();
            termosDeUsoPage.ValidarTermosDeUso();
            termosDeUsoPage.ClicarBotaoTermosUso();
        }

        [Given(@"que faço o login com EC Com Cadastro do Estabelecimento")]
        public void DadoQueFacoOLoginComECComCadastroDoEstabelecimento()
        {
            loginCuponagemPage.AcessarURLLoginPage();
            loginCuponagemPage.PreencherDados();
            loginCuponagemPage.ClicarBotaoEntrar();        
        }

        [Given(@"visualizo a tela Painel de Promocoes")]
        public void DadoVisualizoATelaPainelDePromocoes()
        {
            loginCuponagemPage.AcessarURLLoginPage();
            loginCuponagemPage.PreencherDadosSemCad();
            loginCuponagemPage.ClicarBotaoEntrar();
            tutorialPage.ValidarTutorial();
            tutorialPage.ClicarBotaoProximo();
            termosDeUsoPage.ValidarTermosDeUso();
            termosDeUsoPage.ClicarBotaoTermosUso();
        }

        [Given(@"visualizo a tela Painel de Promocoes Com EC Cadastrado")]
        public void DadoVisualizoATelaPainelDePromocoesComECCadastrado()
        {
            loginCuponagemPage.AcessarURLLoginPage();
            loginCuponagemPage.PreencherDados();
            loginCuponagemPage.ClicarBotaoEntrar();           
        }
        
        [Given(@"sou direcionado para a tela de cadastro de EC")]
        public void DadoSouDirecionadoParaATelaDeCadastroDeEC()
        {
            cadastroDadosECPage.ValidarTelaCadastroEC();
        }
                
        [Given(@"pressiono no botão Criar Promoção")]
        public void DadoQuePressionoNoBotaoCriarPromocao()
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECComPromo();
        }

        [Given(@"pressiono no botão Criar Promoção\(EC_Sem_Cadastro\)")]
        public void DadoPressionoNoBotaoCriarPromocaoEC_Sem_Cadastro()
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECSemPromo();
        }
        
        [Given(@"pressiono no botão Prosseguir")]
        public void DadoPressionoNoBotaoProsseguir()
        {
            cadastroDadosECPage.ClicarBotaoProsseguir();
        }

        [When(@"pressiono no botão Criar Promoção\(EC_Sem_Cadastro\)")]
        public void QuandoPressionoNoBotaoCriarPromocaoEC_Sem_Cadastro()
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECSemPromo();
        }

        [When(@"pressiono no botão Criar Promoção")]
        public void QuandoPressionoNoBotaoCriarPromocao()
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECSemPromo();
        }
        
        [When(@"acesso a tela de Cadastro de Promocao via URL")]
        public void QuandoAcessoATelaDeCadastroDePromocaoViaURL()
        {
            painelPromocoesPage.AcessarURLNovaPromocao();
        }

        [When(@"pressiono no botão Prosseguir")]
        public void QuandoPressionoNoBotaoProsseguir()
        {
            cadastroDadosECPage.ClicarBotaoProsseguir();
        }

        [Then(@"visualizo mensagem de Campos Obrigatórios")]
        public void EntaoVisualizoMensagemDeCamposObrigatorios()
        {
            cadastroDadosECPage.ValidarCamposObrigatorios();
        }
        
        [Then(@"sou direcionado para a tela de cadastro de EC")]
        public void EntaoSouDirecionadoParaATelaDeCadastroDeEC()
        {
            cadastroDadosECPage.ValidarTelaCadastroEC();
        }
        
        [Given(@"visualizo dados para confirmacao (.*),(.*),(.*)")]
        public void DadoVisualizoDadosParaConfirmacaoABCExecutivoBrasileiro(string nomeFantasia, string tipoEstabelecimento, string tipoCozinha)
        {
            criarPromoConfirmarDadosPage.ConfirmarDados(nomeFantasia, tipoEstabelecimento, tipoCozinha);            
        }

    }
}
