using DailyLeetCodeScraper.Modal;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;

namespace DailyLeetCodeScraper;

public class LeetCodeScraper 
{
    public QuestionModal GetDailyQuesiton() 
    {
        var htmlDoc = new HtmlWeb().Load("https://leetcodepotd.vercel.app/");
        var title = htmlDoc.QuerySelectorAll("div");
        
        Console.WriteLine(title);
        
        return new QuestionModal();    
    }
}