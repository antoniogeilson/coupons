using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomacaoCuponagem.Helpers
{
    public static class SetterHelpers
    {
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void EnterText(this IWebElement element, long value)
        {
            SetterHelpers.EnterText(element, value.ToString());
        }

        public static void EnterTextAndWait(this IWebElement element, string value)
        {
            EnterText(element, value);
            Thread.Sleep(3000);
        }

        public static void DoClick(this IWebElement element)
        {
            element.Click();
        }

        public static void DoClickAndWait(this IWebElement element)
        {
            element.Click();
            Thread.Sleep(5000);
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
