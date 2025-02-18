using DailyLeetCodeScraper.Modal;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DailyLeetCodeScraper;

public class LeetCodeScraper 
{
    private const string Url = "https://leetcode.com/problemset/";

    public Question GetDailyQuesiton()
    {
        using (IWebDriver driver = new ChromeDriver()) 
        {
            driver.Navigate().GoToUrl(Url);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(d => d.FindElement(By.Id("__next")));
            
            IWebElement body = driver.FindElement(By.Id("__next"));
            IWebElement dailyQuestion = body.FindElement(By.CssSelector("[role='rowgroup'] div"));
            IWebElement icon = dailyQuestion.FindElement(By.CssSelector("div.mx-2.flex.items-center.py-\\[11px\\] a"));
            icon.Click();
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            
            Console.WriteLine(driver.Url);
        }
        return new Question();
    }
}