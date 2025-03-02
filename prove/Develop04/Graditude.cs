class Graditude : Activity
{
    private List<string> _answers = new List<string>();

    public Graditude()
    {
        _name = "Graditude";
        _description = "This activity will help you center yourself and remember the good things in life";
        _duration = 0;
    }

    public void ListGraditude()
    {
        DisplayIntro();
        Console.WriteLine("List as many things you're grateful for within the time limit.");
        Console.WriteLine("Press Enter when you're ready: ");
        Console.Read();

        GetReady();

        while (startTime < futureTime)
        {
            Time();
            string answer = Console.ReadLine();
            _answers.Add(answer);
        }
        Console.WriteLine("You wrote down " + _answers.Count + "answers.");
        DisplayEnd();
    }
}