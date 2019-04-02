using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace AutomacaoCuponagem.Steps
{
    [Binding]
    public class AlterarDadosECSteps
    {
        private IWebDriver driver;
        private PainelPromocoesPage painelPromocoesPage;
        private AlterarDadosECPage alterarDadosECPage;

        public AlterarDadosECSteps(IWebDriver driver)
        {
            this.driver = driver;
            painelPromocoesPage = new PainelPromocoesPage(driver);
            alterarDadosECPage = new AlterarDadosECPage(driver);
        }

        [Given(@"pressiono botão Salvar")]
        public void DadoPressionoBotaoSalvar()
        {
            alterarDadosECPage.ClicarBotaoSalvar();
        }

        [Given(@"sou direcionado para a tela de Alteração de Dados Do EC")]
        public void DadoSouDirecionadoParaATelaDeAlteracaoDeDadosDoEC()
        {
            alterarDadosECPage.ValidarTelaAlterarDadosEC();
        }

        [Given(@"limpo os campos obrigatórios")]
        public void DadoLimpoOsCamposObrigatorios()
        {
            alterarDadosECPage.LimparCamposAlterarDadosEC();
        }
        
        [Given(@"acesso a tela de Alteração de Dados do EC via URL")]
        public void DadoAcessoATelaDeAlteracaoDeDadosDoECViaURL()
        {
            painelPromocoesPage.AcessarURLAlterarDadosEC();
        }

        [Given(@"atualizo os dados do Estabelecimento")]
        public void DadoAtualizoOsDadosDoEstabelecimento()
        {
            //ajustar tratamento de saida do return para usar na tela de validação
            alterarDadosECPage.AtualizarCEP();
            alterarDadosECPage.GuardarCEPAtualizado();
            alterarDadosECPage.AtualizarNumero();
            alterarDadosECPage.GuardarNumeroAtualizado();
            alterarDadosECPage.AtualizarRestaurante();
            alterarDadosECPage.GuardarRestauranteAtualizado();
            alterarDadosECPage.AtualizarCozinha();
            alterarDadosECPage.GuardarCozinhaAtualizado();
        }
        
        [When(@"acesso a tela de Alteração de Dados do EC via Botão")]
        public void QuandoAcessoATelaDeAlteracaoDeDadosDoECViaBotao()
        {
            painelPromocoesPage.ClicarBotaoAlterarDadosEC();
        }

        [When(@"acesso a tela de Cadastro de Dados do EC via URL")]
        public void QuandoAcessoATelaDeCadastroDeDadosDoECViaURL()
        {
            painelPromocoesPage.AcessarURLCadastrarDadosEC();
        }

        [When(@"acesso a tela de Alteração de Dados do EC via URL")]
        public void QuandoAcessoATelaDeAlteracaoDeDadosDoECViaURL()
        {
            painelPromocoesPage.AcessarURLAlterarDadosEC();
        }

        [When(@"pressiono botão Salvar")]
        public void QuandoPressionoBotaoSalvar()
        {
            alterarDadosECPage.ClicarBotaoSalvar();
        }

        [Then(@"sou direcionado para a tela de Alteração de Dados Do EC")]
        public void EntaoSouDirecionadoParaATelaDeAlteracaoDeDadosDoEC()
        {
            alterarDadosECPage.ValidarTelaAlterarDadosEC();
        }

        [Then(@"visualizo mensagem de Campos Obrigatórios \(Tela de Alteração\)")]
        public void EntaoVisualizoMensagemDeCamposObrigatoriosTelaDeAlteracao()
        {
            alterarDadosECPage.MsgCamposObrigatorios();
        }

        [Then(@"visualizo a Mensagem de Confirmacao \(Alteração EC\)")]
        public void EntaoVisualizoAMensagemDeConfirmacaoAlteracaoEC()
        {
            painelPromocoesPage.ValidarMsgECAlterado();
        }

        [Then(@"visualizo dados do EC Alterados")]
        public void EntaoVisualizoDadosDoECAlterados()
        {
            alterarDadosECPage.ValidarDadosECAlterado();
        }        
    }
}
