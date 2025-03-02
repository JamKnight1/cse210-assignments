class Reflection : Activity
{
    private List<string> _prompts = new List<string>
    (
        new string[]
        {
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something very difficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless",
            "Think of a time when you were very brave"
        }
    );
    private List<string> _questions = new List<string>
    (
        new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than the other times when you were not as successful?",
            "What is your favorite part of this experience?",
            "What could you learn from this experience that applies to other situations in your life?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        }
    );
    public Reflection()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }

    public void DisplayPrompt()
    {
        DisplayIntro();
        Console.WriteLine("Think about the following prompt:");

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("---" +_prompts[index] + "---");

        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        GetReady();
    }

    public void AnswerQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience: ");
        while (startTime < futureTime)
            Time();
            Console.Clear();
            foreach (string question in _questions)
            {
                Random random = new Random();
                int index = random.Next(_questions.Count);
                Console.WriteLine(question[index]);
                Console.ReadLine();
                Thread.Sleep(3000);
            }
        DisplayEnd();    
            
    }
}