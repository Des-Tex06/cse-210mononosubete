using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {   
        _prompts.Add("What were your thorns and what were your roses today?");
        _prompts.Add("What was your favorite meal today?");
        _prompts.Add("If you read anything today, what did you read? (like a physical book)");
        _prompts.Add("Which hobby did you engage in today?");
        _prompts.Add("In your scripture readings today, where and what did you read and what interested you the most?");
        _prompts.Add("How has the Lord blessed you today? What were the tender mercies?");
        _prompts.Add("If you could restart and have a do-over in any period of your day which would it be?");

        Random random = new ();
        int index = random.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[index]);


        return "";
    }
}
