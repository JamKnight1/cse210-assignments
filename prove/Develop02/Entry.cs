
public class Entry{
    public string _date;
    public string _prompt;
    public string _response;
    public string _goal;
     

    public void WriteEntry()
    {
        Console.Write("Please enter the date of your entry: ");
        _date = Console.ReadLine();
        
        
        Prompt prompt = new Prompt();
        _prompt = prompt.ChoosePrompt();
        Console.WriteLine(_prompt);

        _response = Console.ReadLine();

        Console.Write("What is your goal for tomorrow? ");
        _goal = Console.ReadLine();

    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Goal: {_goal}");
    }
}