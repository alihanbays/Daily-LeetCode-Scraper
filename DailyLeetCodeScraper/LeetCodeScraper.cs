using DailyLeetCodeScraper.Modal;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;

namespace DailyLeetCodeScraper;

public class LeetCodeScraper 
{
    private const string Url = "https://leetcodepotd.vercel.app/";

    public Question GetDailyQuesiton()
    {
        HtmlDocument? htmlDocument = new HtmlWeb().Load(Url);
        IList<HtmlNode>? title = htmlDocument.QuerySelectorAll("div");
        
        Console.WriteLine(title);
        
        return new Question();    
    }
}