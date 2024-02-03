using System;

public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "first prompt",
        "second prompt",
        "third prompt",
        "fourth prompt",
        "fifth prompt"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}