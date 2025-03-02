class Listing : Activity
{   
    private List <string> _prompts = new List<string>
    (
        new string[]
        {
            "Who are people that appriciate you?",
            "What are things that make you happy?",
            "What are your personal strengths?",
            "Who are people that have helped you this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        }
    );
    private List<string> _responses = new List<string>();
    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
    }

    public void DoActivity()
    {
        DisplayIntro();
        Console.WriteLine("List as many responses as you can for the following prompt:");
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("---" + _prompts[index] + "---");

        GetReady();
        
        while (startTime < futureTime)
        {
            Time();
            string response = Console.ReadLine();
            _responses.Add(response);
        }
        Console.WriteLine("You entered " + _responses.Count + " responses.");
        DisplayEnd();
    }
}