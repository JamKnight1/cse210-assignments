public class Checklist : Goal
{
    private int _bonusPoints;
    private int _steps;
    private int _stepCounter;

    public Checklist()
    {}
      public Checklist(string name, int points, int bonusPoints, int steps, int stepCounter)
    {
        _name = name;
        _points = points;
        _bonusPoints = bonusPoints;
        _steps = steps;
        _stepCounter = stepCounter;
    }
    public override void CreateChildGoal()
    { 
        CreateGoal();

        Console.WriteLine("How many times does this goal need to be accomplished?");
        _steps = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the bonus for completing the goal?");
        _bonusPoints = Convert.ToInt32(Console.ReadLine());

        _stepCounter = 0;
    }

    public override bool IsComplete()
    {
        if (_stepCounter >= _steps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override void RecordEvent()
    {
        _stepCounter ++;
    }
    public override void ListGoal()
    {
        bool status = IsComplete();
        if (status == true)
        {
            _check = "X";
        }
        else{
            _check = " ";
        }
        Console.WriteLine($"[{_check}] {_name} -- Currently completed {_stepCounter}/{_steps}");
    }
    public override string SaveGoal()
    {
        string line = "";
        line = $"Checklist Goal: {_name}, {_points.ToString()}, {_bonusPoints.ToString()}, {_steps.ToString()}, {_stepCounter.ToString()}";
        return line;
    }
     public override int CalculateAGP()
    {
        int points = 0;

        points = _stepCounter * _points;

        bool status = IsComplete();

        if (status == true) {
            points += _bonusPoints;
        }

        return points;

    }
}
