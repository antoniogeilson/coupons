using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace AutomacaoCuponagem.Steps
{
    [Binding]
    public class BloquearUsuariosSteps
    {
        private IWebDriver driver;
        private PainelAdministrativoPage painelAdministrativoPage;
        private LoginCuponagemPage loginCuponagemPage;
        private PainelPromocoesPage painelPromocoesPage;

        public BloquearUsuariosSteps(IWebDriver driver)
        {
            this.driver = driver;
            painelAdministrativoPage = new PainelAdministrativoPage(driver);
            loginCuponagemPage = new LoginCuponagemPage(driver);
            painelPromocoesPage = new PainelPromocoesPage(driver);
        }
        
        [Given(@"visualizo Painel Administrativo - opção Bloqueados")]
        public void DadoVisualizoPainelAdministrativo_OpcaoBloqueados()
        {
            painelAdministrativoPage.AcessarPainelAdministrativo();
            painelAdministrativoPage.RealizarLogin();
            painelAdministrativoPage.AcessarPainelAdministrativoRestrito();
        }
        
        [Given(@"bloqueio o cnpj do EC (.*)")]
        public void DadoBloqueioOCnpjDoEC(string cnpj)
        {
            painelAdministrativoPage.BloquearUsuario(cnpj);            
        }
        
        [When(@"acesso Painel de Promoções com usuário bloqueado (.*)")]
        public void QuandoAcessoPainelDePromocoesComUsuarioBloqueado(string cnpj)
        {
            loginCuponagemPage.AcessarURLLoginPage();
            loginCuponagemPage.PreencherDadosUsuarioBloqueado(cnpj);
            loginCuponagemPage.ClicarBotaoEntrar();
        }
        
        [Then(@"visualizo Mensagem de Usuário Bloqueado\.")]
        public void EntaoVisualizoMensagemDeUsuarioBloqueado_()
        {
            painelPromocoesPage.ValidarMsgECBloqueado();            
        }

        [Then(@"o campo Criar Promoção está desabilitado")]
        public void EntaoOCampoCriarPromocaoEstaDesabilitado()
        {
            painelPromocoesPage.ValidarBotaoDesabilitado();
        }

    }
}
