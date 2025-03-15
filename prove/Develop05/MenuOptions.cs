public class MenuOptions
{
     public List<Goal> _goals = new List<Goal>();
     public static double _score;
     public double GetAccumulatedPoints(){
        double points = _score;
        return points;
    }
     public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the file name? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            double total = GetAccumulatedPoints();
            outputFile.WriteLine(total.ToString());

            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();

        string fileName = "";
        Console.Write("What is the file name? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = Convert.ToInt32(lines[0]);

         for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                Simple simpleGoal = new Simple(parts[1], Convert.ToInt32(parts[2]), Convert.ToBoolean(parts[3]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                Eternal eternalGoal = new Eternal(parts[1], Convert.ToInt32(parts[2]));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                Checklist checklistGoal = new Checklist(parts[1], Convert.ToInt32(parts[2]), Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]));
                _goals.Add(checklistGoal);
            }
        }
    }
    
    public double CalculateTotalAGP()
    {
        double totalAGP = _score;
        foreach(Goal goal in _goals) {
            totalAGP += goal.CalculateAGP();
        }

        _score = totalAGP;

        return totalAGP;
    }

    public void RecordEventInTracker()
    {
        string goalIndex = "";
        Console.Write("Which goal did you accomplish? ");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].IsComplete() == false) {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].CalculateAGP();

            _score += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_score} points");

        } else {

            Console.WriteLine("You have already completed this goal.");

        }
    }
      public virtual void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }
}