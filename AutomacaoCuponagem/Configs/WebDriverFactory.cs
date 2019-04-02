using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Configuration;
using System.IO;

namespace AutomacaoCuponagem.Configs
{
    public enum DriverType
    {
        Chrome, Firefox, IE, PhantomJS, AppiumDriver
    }

    public static class WebDriverFactory
    {        
        public static IWebDriver Create()
        {
            var driver = new ChromeDriver(DriversPath);
            
            if (ConfigurationManager.AppSettings["Resolucao"] == "web")
            {
                driver.Manage().Window.Maximize();
            }
            if (ConfigurationManager.AppSettings["Resolucao"] == "Mobile")
            {
                if (ConfigurationManager.AppSettings["Plataforma"] == "IOS")
                {
                    if (ConfigurationManager.AppSettings["Modelo"] == "Iphone6")
                    {
                        driver.Manage().Window.Size = new System.Drawing.Size(375, 667);
                    }
                    if (ConfigurationManager.AppSettings["Modelo"] == "Ipad")
                    {
                        driver.Manage().Window.Size = new System.Drawing.Size(768, 1024);
                    }
                }
                if (ConfigurationManager.AppSettings["Plataforma"] == "Android")
                {
                    if (ConfigurationManager.AppSettings["Modelo"] == "LGG5")
                    {
                        driver.Manage().Window.Size = new System.Drawing.Size(640, 360);
                    }
                    if (ConfigurationManager.AppSettings["Modelo"] == "Nexus10")
                    {
                        driver.Manage().Window.Size = new System.Drawing.Size(1280, 800);
                    }
                }
            }
            else
            {
                // mostrar mensagem "Favor Verificar As Chaves Resolucao, Plataforma e Modelo no Arquivo App.config";
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            return driver;
        }

        public static string DriversPath
        {
            get
            {
                return Path.Combine(AppContext.BaseDirectory, "Drivers");
            }
        }

        public static object Message { get; private set; }
    }
}