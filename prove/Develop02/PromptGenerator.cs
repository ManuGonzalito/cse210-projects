public class PromptGenerator
{
    public List<string> _prompts = new() {
        "What was the best part of my day?",
        "How I felt today?",
        "What did I learn on this day?",
        "What a good works I did today",
        "What gospel principles did I apply today?",
        "If I had one thing I could do over today, what would it be?",
        "Who was the most interesting person I interacted with today?",
        "What obstacles did I manage to overcome today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new();
        int index = random.Next(_prompts.Count());
        return _prompts[index];
    }
}