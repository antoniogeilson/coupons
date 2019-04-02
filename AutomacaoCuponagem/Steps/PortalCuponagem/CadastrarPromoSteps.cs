using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem.Steps
{
    [Binding]
    public class CadastrarPromoSteps
    {
        //Criar Construtores do driver e Classe

        private IWebDriver driver;
        private LoginCuponagemPage loginCuponagemPage;
        private CriarPromoDadosEstabPage criarPromoDadosEstabPage;
        private CriarPromoDadosPromoPage criarPromoDadosPromoPage;
        private CriarPromoConfirmarDadosPage criarPromoConfirmarDadosPage;
        private PainelPromocoesPage painelPromocoesPage;
        private ReservarCuponsService reservarCuponsService;
        
        public CadastrarPromoSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginCuponagemPage = new LoginCuponagemPage(driver);
            criarPromoDadosEstabPage = new CriarPromoDadosEstabPage(driver);
            criarPromoDadosPromoPage = new CriarPromoDadosPromoPage(driver);
            criarPromoConfirmarDadosPage = new CriarPromoConfirmarDadosPage(driver);
            painelPromocoesPage = new PainelPromocoesPage(driver);
            reservarCuponsService = new ReservarCuponsService(driver);
            
        }
        // DADO_E
        [Given(@"que estou na tela de Criar Promoção")]
        public void DadoQueEstouNaTelaDeCriarPromocao()
        {
            loginCuponagemPage.AcessarURLLoginPage();
            loginCuponagemPage.PreencherDados();
            loginCuponagemPage.ClicarBotaoEntrar();
            criarPromoDadosEstabPage.AcessarTelaCriarPromocao();
        }

        [Given(@"preencho os dados do Estabelecimento (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void DadoPreenchoOsDadosDoEstabelecimentoABCBlocoBBrasileiro
            (string nomeFantasia, string cep, string numero, string complemento, string tipoEstabelecimento, string tipoCozinha)
        {
            criarPromoDadosEstabPage.PreencherCamposEstabelecimento
                (nomeFantasia, cep, numero, complemento, tipoEstabelecimento, tipoCozinha);
        }

        [Given(@"preencho os dados do Estabelecimento\. Com CEP Unico (.*), (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void DadoPreenchoOsDadosDoEstabelecimento_ComCEPUnicoComercioDaCidadeRuaJoseTeodoroCentroExecutivoBrasileiro
            (string nomeFantasia, string cep, string endereco, string bairro, string numero, string tipoEstabelecimento, string tipoCozinha)
        {
            criarPromoDadosEstabPage.PreencherCamposEstabelecimentoCepUnico
                (nomeFantasia, cep, endereco, bairro, numero, tipoEstabelecimento, tipoCozinha);
        }
        
        [Given(@"preencho os dados da Promocao")]
        public void DadoPreenchoOsDadosDaPromocao(string valor)
        {
           criarPromoDadosPromoPage.PreencherTipoDescValor(valor);
        }

        [Given(@"preencho os dados da Promocao \(Porcentagem\) (.*)")]
        public void DadoPreenchoOsDadosDaPromocaoPorcentagem(string percentual)
        {
            criarPromoDadosPromoPage.PreencherTipoDescPercent(percentual);
        }

        [Given(@"preencho os dados da Promocao \(Valor\) (.*)")]
        public void DadoPreenchoOsDadosDaPromocaoValor(string valor)
        {
            criarPromoDadosPromoPage.PreencherTipoDescValor(valor);
        }

        [Given(@"preencho os dados da Promocao \(Brinde\) (.*)")]
        public void DadoPreenchoOsDadosDaPromocaoBrinde(string brinde)
        {
            criarPromoDadosPromoPage.PreencherTipoDescBrinde(brinde);
        }

        [Given(@"pressiono botão Proximo Passo \(Estabelecimento\)")]
        public void DadoPressionoBotaoProximoPassoEstabelecimento()
        {
            criarPromoDadosEstabPage.ClicarBotaoProximoPasso();
        }

        [Given(@"pressiono botão Proximo Passo \(Promocao\)")]
        public void DadoPressionoBotaoProximoPassoPromocao()
        {
            criarPromoDadosPromoPage.ClicarBotaoProximoPasso();
        }

        [Given(@"visualizo tela para confirmacao\(Porcentagem\) (.*)")]
        public void DadoVisualizoTelaParaConfirmacaoPorcentagem(string percentual)
        {
            criarPromoConfirmarDadosPage.ConfirmarDadosPercentual(percentual);

        }

        [Given(@"visualizo tela para confirmacao\(Valor\) (.*)")]
        public void DadoVisualizoTelaParaConfirmacaoValor(string valor)
        {            
            criarPromoConfirmarDadosPage.ConfirmarDadosValor(valor);         
        }

        [Given(@"visualizo tela para confirmacao\(Brinde\) (.*)")]
        public void DadoVisualizoTelaParaConfirmacaoBrindeCafe(string brinde)
        {
            criarPromoConfirmarDadosPage.ConfirmarDadosBrinde(brinde);
        }
        
        [Given(@"visualizo dados para confirmacao  (.*), (.*), (.*),")]
        public void DadoVisualizoDadosParaConfirmacaoABCExecutivoBrasileiro
            (string nomeFantasia, string tipoEstabelecimento, string tipoCozinha)
        {
            criarPromoConfirmarDadosPage.ConfirmarDados(nomeFantasia, tipoEstabelecimento, tipoCozinha);
        }
        
        //QUANDO
        [When(@"pressiono botão Proximo Passo \(Estabelecimento\)")]
        public void QuandoPressionoBotaoProximoPassoEstabelecimento()
        {
            criarPromoDadosEstabPage.ClicarBotaoProximoPasso();
        }

        [When(@"pressiono botão Cancelar \(Estabelecimento\)")]
        public void QuandoPressionoBotaoCancelarEstabelecimento()
        {
            criarPromoDadosEstabPage.AcessarTelaCriarPromocao();
        }

        [When(@"pressiono botão Proximo Passo \(Promocao\)")]
        public void QuandoPressionoBotaoProximoPassoPromocao()
        {
            criarPromoDadosPromoPage.ClicarBotaoProximoPasso();
        }

        [When(@"pressiono botão Criar Promocao")]
        public void QuandoPressionoBotaoCriarPromocao()
        {
            criarPromoConfirmarDadosPage.ClicarBotaoCriarPromocao();
        }
        
        [When(@"preencho campo CEP com valor inválido (.*)")]
        public void QuandoPreenchoCampoCEPComValorInvalido(string cep)
        {
           criarPromoDadosEstabPage.PreencherCampoCEPValorInvalido(cep);
        }

        //ENTÃO
        [Then(@"visualizo a Mensagem de Cep Inválido")]
        public void EntaoVisualizoAMensagemDeCepInvalido()
        {
            criarPromoDadosEstabPage.MensagemCEPInvalido();
        }
                
        [Then(@"visualizo a tela Criar Promocao - Dados da Promocao")]
        public void EntaoVisualizoATelaCriarPromocao_DadosDaPromocao()
        {
            criarPromoDadosEstabPage.ValidarTelaDadosDaPromocao();
        }
        
        [Then(@"visualizo a tela Criar Promocao - Confirmar Dados")]
        public void EntaoVisualizoATelaCriarPromocao_ConfirmarDados()
        {
            criarPromoDadosPromoPage.ValidarTelaDadosConfirmarDados();
        }

        [Then(@"visualizo a Mensagem de Confirmacao")]
        public void EntaoVisualizoAMensagemDeConfirmacao()
        {                      
            painelPromocoesPage.ValidarPromoOk();
        }
        

        [Then(@"Cupom de Porcentagem Criado\(Porcentagem\) (.*)")]
        public void EntaoCupomDePorcentagemCriadoPorcentagem(string percentual)
        {
            painelPromocoesPage.ValidarPromoPercentual(percentual);
        }

        [Then(@"Cupom de Valor Criado\(Valor\) (.*)")]
        public void EntaoCupomDeValorCriadoValor(string valor)
        {
            painelPromocoesPage.ValidarPromoValor(valor);
        }

        [Then(@"Cupom de Brinde Criado\(Brinde\) (.*)")]
        public void EntaoCupomDeBrindeCriadoBrindeCafe(string brinde)
        {
            painelPromocoesPage.ValidarPromoBrinde(brinde);
        }

        //Este Método Cria uma Promoção Para Utilizar Como Massa de Cancelamento
        [Given(@"visualizo uma Promocao Ativa (.*)")]
        public void DadoVisualizoUmaPromocaoAtiva(string percentual)
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECComPromo();
            criarPromoDadosPromoPage.PreencherTipoDescPercent(percentual);
            criarPromoDadosPromoPage.ClicarBotaoProximoPasso();
            criarPromoConfirmarDadosPage.ClicarBotaoCriarPromocao();
        }

        //Este STEP Cria e Expira uma Promoção Para Utilizar Como Massa de Relançamento
        [Given(@"visualizo uma Promoção\(Porcentagem\) Expirada (.*)")]
        public void DadoVisualizoUmaPromocaoPorcentagemExpirada(string percentual)
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECComPromo();
            criarPromoDadosPromoPage.PreencherTipoDescPercent(percentual);
            criarPromoDadosPromoPage.ClicarBotaoProximoPasso();
            criarPromoConfirmarDadosPage.ClicarBotaoCriarPromocao();
            reservarCuponsService.ReservarTodosCuponsRelancarPromo();            
        }

        //Este STEP Cria e Expira uma Promoção Para Utilizar Como Massa de Relançamento
        [Given(@"visualizo uma Promoção\(valor\) Expirada (.*)")]
        public void DadoVisualizoUmaPromocaoValorExpirada(string valor)
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECComPromo();
            criarPromoDadosPromoPage.PreencherTipoDescValor(valor);
            criarPromoDadosPromoPage.ClicarBotaoProximoPasso();
            criarPromoConfirmarDadosPage.ClicarBotaoCriarPromocao();
            reservarCuponsService.ReservarTodosCuponsRelancarPromo();
        }
        
        [Given(@"visualizo uma Promoção\(brinde\) Expirada (.*)")]
        public void DadoVisualizoUmaPromocaoBrindeExpirada(string brinde)
        {
            painelPromocoesPage.ClicarBotaoCriarPromocao_ECComPromo();
            criarPromoDadosPromoPage.PreencherTipoDescBrinde(brinde);
            criarPromoDadosPromoPage.ClicarBotaoProximoPasso();
            criarPromoConfirmarDadosPage.ClicarBotaoCriarPromocao();
            reservarCuponsService.ReservarTodosCuponsRelancarPromo();
        }
        
    }
}











