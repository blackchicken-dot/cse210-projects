using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> Prompts { get; set; }

    public PromptGenerator()
    {
        Prompts = new List<string>()
        {
            "If I had one thing I could do over today, what would it be?",
            "What was the best part of my day?",
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "Reflect on your goals: Are you on track? What adjustments can you make?",
            "What did you learn about yourself today?",
        };
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        return Prompts[random.Next(Prompts.Count)];
    }
}