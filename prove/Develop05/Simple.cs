public class Simple : Goal
{
    public Simple()
    {
        _name = "Name of Simple Goal";
        _points = 0;
        _status = false;
    }

    public Simple(string name, int points, bool status)
    {
        _name = name;
        _points = points;
        _status = status;
    }
    public override void CreateChildGoal()
    {
        CreateGoal();
    }

    public override void RecordEvent()
    {
        if (_status == false)
        {
            _status = true;
        }
        else
        {
            Console.WriteLine("You've already completed this goal");
        }
    }

    public override bool IsComplete()
    {
        if (_status == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal: {_name}, {_points}, {IsComplete().ToString()}";
        return line;
    }
       public override int CalculateAGP()
    {
        bool status = IsComplete();
        int aGP = 0;
        if (status == true) {
            aGP = _points;
        } else {
            aGP = 0;
        }
        return aGP;
    }
}