class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int startTime;
    protected int futureTime;
    

    public Activity()
    {
        _name = "Activity";
        _description = "This is an activity.";
        _duration = 0;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayIntro()
    {
        Console.WriteLine("Welcome to the " + _name + " Activity!");
        Console.WriteLine(_description);

        Console.WriteLine("How long would you like to do this activity?");
        Console.Write("Enter the duration in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void Time()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
    }
    

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(".");
            Thread.Sleep(1000);
        }
    }

    public void DisplayEnd()
    {
        Console.WriteLine("Good job!");
        Thread.Sleep(3000);

        Console.WriteLine("You have completed the " + _name + " Activity!");
        Console.WriteLine("You did this activity for " + _duration + " seconds.");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(".");
            Thread.Sleep(1000);
        }

    }


}  