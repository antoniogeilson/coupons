using AutomacaoCuponagem.Configs;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace Edenred.QA.TestesFuncionais.Configs
{
    [Binding]
    public class ConfigurationBinding
    {
        private readonly IObjectContainer objectContainer;
        public string feature = FeatureContext.Current.FeatureInfo.Title;
        public string scenario = ScenarioContext.Current.ScenarioInfo.Title;
            
        public ConfigurationBinding(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario("web")]
        public void InitializeWebDriver()
        {
            var driver = WebDriverFactory.Create();

            System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["Screenshots"] + feature);

            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario("web")]
        public void DisposeWebDriver()
        {
            var driver = objectContainer.Resolve<IWebDriver>();

            Thread.Sleep(100);
            driver.TakeScreenshot().SaveAsFile(ConfigurationManager.AppSettings["Screenshots"] + feature + "\\" + scenario + ".png", 0);

            if (driver != null)
            {
                //driver.Quit();
            }
        }

        [BeforeScenario("android")]
        public void InitializeMobileDriver()
        {
            AppiumDriver<AndroidElement> driver;

            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "Antonio");
            cap.SetCapability("platformVersion", "6.0.0");
            cap.SetCapability("app", "C:/repos/Mobile/APK/SimpleCalculator.apk");
            cap.SetCapability("androidPackage", "net.tecnotopia.SimpleCalculator");
            cap.SetCapability("appActivity", "net.tecnotopia.SimpleCalculator.MainActivity");
            cap.SetCapability("platformName", "Android");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario("android")]
        public void DisposeMobileDriver()
        {
            var driver = objectContainer.Resolve<IWebDriver>();
                        
            if (driver != null)
            {
                driver.Quit();
            }
        }

        [BeforeScenario("service")]
        public void InitializeService()
        {
            
        }
        [AfterScenario("service")]
        public void DisposeService()
        {
            
        }        
    }
}
