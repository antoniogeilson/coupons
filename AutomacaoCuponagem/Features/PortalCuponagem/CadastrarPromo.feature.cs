﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomacaoCuponagem.Features.PortalCuponagem
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Cuponagem_Cadastrar Promoção")]
    public partial class Cuponagem_CadastrarPromocaoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CadastrarPromo.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Cuponagem_Cadastrar Promoção", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1-Criar_Promocao-Porcentagem")]
        [NUnit.Framework.CategoryAttribute("web")]
        [NUnit.Framework.TestCaseAttribute("15", null)]
        public virtual void _1_Criar_Promocao_Porcentagem(string percentual, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "web"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1-Criar_Promocao-Porcentagem", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("visualizo a tela Painel de Promocoes Com EC Cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 7
 testRunner.And("pressiono no botão Criar Promoção", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 8
 testRunner.And(string.Format("preencho os dados da Promocao (Porcentagem) {0}", percentual), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 9
 testRunner.And("pressiono botão Proximo Passo (Promocao)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.And(string.Format("visualizo tela para confirmacao(Porcentagem) {0}", percentual), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 11
 testRunner.When("pressiono botão Criar Promocao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 12
 testRunner.Then("visualizo a Mensagem de Confirmacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 13
 testRunner.And(string.Format("Cupom de Porcentagem Criado(Porcentagem) {0}", percentual), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2-Criar_Promocao-Valor")]
        [NUnit.Framework.CategoryAttribute("web")]
        [NUnit.Framework.TestCaseAttribute("19", null)]
        public virtual void _2_Criar_Promocao_Valor(string valor, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "web"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2-Criar_Promocao-Valor", @__tags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("visualizo a tela Painel de Promocoes Com EC Cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 21
 testRunner.And("pressiono no botão Criar Promoção", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 22
 testRunner.And(string.Format("preencho os dados da Promocao (Valor) {0}", valor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 23
 testRunner.And("pressiono botão Proximo Passo (Promocao)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 24
 testRunner.And(string.Format("visualizo tela para confirmacao(Valor) {0}", valor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 25
 testRunner.When("pressiono botão Criar Promocao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 26
 testRunner.Then("visualizo a Mensagem de Confirmacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 27
 testRunner.And(string.Format("Cupom de Valor Criado(Valor) {0}", valor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3-Criar_Promocao-Brinde")]
        [NUnit.Framework.CategoryAttribute("web")]
        [NUnit.Framework.TestCaseAttribute("Café", null)]
        public virtual void _3_Criar_Promocao_Brinde(string brinde, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "web"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3-Criar_Promocao-Brinde", @__tags);
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
 testRunner.Given("visualizo a tela Painel de Promocoes Com EC Cadastrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 35
 testRunner.And("pressiono no botão Criar Promoção", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 36
 testRunner.And(string.Format("preencho os dados da Promocao (Brinde) {0}", brinde), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 37
 testRunner.And("pressiono botão Proximo Passo (Promocao)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 38
 testRunner.And(string.Format("visualizo tela para confirmacao(Brinde) {0}", brinde), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 39
 testRunner.When("pressiono botão Criar Promocao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 40
 testRunner.Then("visualizo a Mensagem de Confirmacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 41
 testRunner.And(string.Format("Cupom de Brinde Criado(Brinde) {0}", brinde), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
