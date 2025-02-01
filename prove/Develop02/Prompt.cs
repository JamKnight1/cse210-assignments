public class Prompt
{
    public List<string>_prompts = new List<string>
    {
        "What was the best part of your day?",
        "Who did you talk to today? What did you talk about?",
        "How did you see the Spirit working in your life today?",
        "What did you learn today?",
        "What was the hardest part of your day? How did you get through it?",
    };

    public string ChoosePrompt()
    {
        Random rnd = new Random();

        int index = rnd.Next(_prompts.Count);

        return _prompts[index];
    }
}