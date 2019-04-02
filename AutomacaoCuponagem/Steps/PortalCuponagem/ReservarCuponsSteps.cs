using AutomacaoCuponagem.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomacaoCuponagem
{
    [Binding]
    public class ReservarCuponsSteps
    {
        private IWebDriver driver;
        private ReservarCuponsService reservarCuponsService;

        public ReservarCuponsSteps(IWebDriver driver)

        {
           this.driver = driver;
        reservarCuponsService = new ReservarCuponsService(driver);
        }
               
        [Given(@"que reservo todos os cupons de uma promoção")]
        public void DadoQueReservoTodosOsCuponsDeUmaPromocao()
        {
            reservarCuponsService.ReservarTodosCupons();
        }
    }
}
