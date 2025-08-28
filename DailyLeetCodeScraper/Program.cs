// See https://aka.ms/new-console-template for more information

using System.Net;
using DailyLeetCodeScraper.Modal;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DailyLeetCodeScraper;

class Program 
{
    static void Main() 
    {
        try 
        {
            LeetCodeScraper leetCodeScraper = new();
            Question res = leetCodeScraper.GetDailyQuesiton();
            EmailUtils emailUtils = new();
            emailUtils.SendMailAsync(res).Wait();
        }
        catch (Exception e) 
        {
            Console.WriteLine("Error happened: " + e.Message);
        }
    }
    
}