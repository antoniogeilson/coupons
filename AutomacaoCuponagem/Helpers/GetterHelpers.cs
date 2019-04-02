using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace AutomacaoCuponagem.Helpers
{
    public static class GetterHelpers
    {
        public static string GetText(this IWebElement element)
        {
            return element.Text;
        }

        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}