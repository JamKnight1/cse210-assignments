public abstract class Goal
{
    protected string _name;
    public static double _score;
    protected int _points;
    protected bool _status;
    protected string _check = "";
    public List<Goal> _goals = new List<Goal>();


    public Goal()
    {
        _name = "Goal";
        _points = 0;
    }
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public static void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

   
    public virtual void CreateGoal()
    {
         Console.Write("What is the goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        _status = false;
    }

    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }
   

    public virtual void CreateChildGoal()
    {

    }
    public virtual void ListGoal()
    {

    }
    public virtual int CalculateAGP()
    {
        return 0;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

  

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

}