namespace DailyLeetCodeScraper.Modal;

public class Question 
{
    public string Title { get; set; }
    public string Body { get; set; }
    public Example Examples { get; set; }
    public string Constraints { get; set; }
    public Hint Hints { get; set; }
}

public class Hint
{
    public string Title { get; set; }
    public string Body { get; set; }
}

public class Example
{
    public string Title { get; set; }
    public string Body { get; set; }
}