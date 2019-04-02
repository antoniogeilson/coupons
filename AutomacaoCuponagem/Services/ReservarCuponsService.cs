using AutomacaoCuponagem.Configs;
using BoDi;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Threading;

namespace AutomacaoCuponagem.PageObjects
{
    public class ReservarCuponsService
    {
        private IWebDriver driver;
        private PainelPromocoesPage painelPromocoesPage;
        private CriarPromoConfirmarDadosPage criarPromoConfirmarDadosPage;
                        
        // Consutrutor
        public ReservarCuponsService(IWebDriver driver)
        {
            this.driver = driver;
            painelPromocoesPage = new PainelPromocoesPage(driver);
            criarPromoConfirmarDadosPage = new CriarPromoConfirmarDadosPage(driver);
        }

        //------------------------------------------------------------------------//
        //              Reserva de Cupons - Fluxo Relançar Promo                  //
        //------------------------------------------------------------------------//     

        //Reserva de Cupons - Fluxo Relançar Promo   
        public void ReservarTodosCuponsRelancarPromo()
        {
            var url = painelPromocoesPage.PegarUrlCupom();         
            var qtdeCupons = criarPromoConfirmarDadosPage.PegarQtdeCupom();

            string urlAPI= "https://user.api-cuponagem.com/promotions/";
            var WEBSERVICE_URL = string.Concat(urlAPI, url, "/book");

            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ReservandoCupons"]);
            
            for (int i = 0; i < qtdeCupons; i++)
            {
                //Gerador Randomico de XUser (Header Utilizado Para Reserva de Cupons) 
                var rnd = new Random();
                var headerXuser = rnd.Next(100000, 999999);
                var headerXuser1 = Convert.ToString(headerXuser);

                try
                {
                    var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                    if (webRequest != null)
                    {
                        //webRequest.Method = "GET";
                        webRequest.Method = "POST";
                        webRequest.Timeout = 12000;
                        webRequest.ContentType = "application/json";
                        webRequest.Headers.Add("x-user", headerXuser1);
                        webRequest.Headers.Add("x-user-client", "user-app");

                        using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                        {
                            using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                            {
                                var jsonResponse = sr.ReadToEnd();
                                Console.WriteLine(String.Format("Response: {0}", jsonResponse));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    
                    //Atualizar Pagina de Cupons
                    //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLCadPromo"]);
                 }
            }

            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLCadPromo"]);
            Thread.Sleep(1000);
        }

        //------------------------------------------------------------------------//
        //                    Reserva de Cupons - Manual                          //
        //------------------------------------------------------------------------//

        //Dados Utiizados Para Reserva de Cupons - Manual
        public string urlPromo = "https://user.api-cuponagem.com/promotions/";
        public string promoCode = "5a044ec1a43fee0013f827e7";
        int qtdCupons1 = 25;
                
        //Reserva de Cupons - Manual    
        public void ReservarTodosCupons()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ReservandoCupons"]);

            for (int i = 0; i < qtdCupons1; i++)
            {
                //URL Para Reserva de Cupons
                string WEBSERVICE_URL = urlPromo + promoCode + "/book";

                //Gerador Randomico de XUser (Header Utilizado Para Reserva de Cupons) 
                Random rnd = new Random();
                int headerXuser = rnd.Next(100000, 999999);
                string headerXuser1 = Convert.ToString(headerXuser);

                try
                {
                    var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                    if (webRequest != null)
                    {
                        //webRequest.Method = "GET";
                        webRequest.Method = "POST";
                        webRequest.Timeout = 12000;
                        webRequest.ContentType = "application/json";
                        webRequest.Headers.Add("x-user", headerXuser1);
                        webRequest.Headers.Add("x-user-client", "user-app");

                        using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                        {
                            using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                            {
                                var jsonResponse = sr.ReadToEnd();
                                Console.WriteLine(String.Format("Response: {0}", jsonResponse));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URLCadPromo"]);
        }
        //------------------------------------------------------------------------//
        //------------------------------------------------------------------------//
        //------------------------------------------------------------------------//
    }
}
                                                                                   
                    
                         