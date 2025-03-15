public class Eternal : Goal
{
    private int _counter;
    public Eternal()
    {
        _name = "Name of Eternal Goal";
        _points = 0;
        _counter = 0;
    }

    public Eternal(string name, int points)
    {
        _name = name;
        _points = points;
        _counter = 0;
    }
    public override void CreateChildGoal()
    {
        CreateGoal();
    }
    public override void ListGoal()
    {
        Console.Write($"[ ] {_name}");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal: {_name}, {_points}, {_points.ToString()}";
        return line;
    }
    public override void RecordEvent()
    {
        _counter ++;
    }
      public override int CalculateAGP()
    {
        int points = _points;
        return points;
    }
}