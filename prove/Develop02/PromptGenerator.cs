using System;

public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "What is the one thing you cannot imagine your life without?",
        "From today, what action are you the proudest of?",
        "Share three things you learned today.",
        "What are you going to do tomorrow to make it great?",
        "Share a tender moment from today."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}