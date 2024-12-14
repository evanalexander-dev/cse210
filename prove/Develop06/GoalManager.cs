public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score;

    public void Start()
    {
        int choice;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 6);
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    private void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (var i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i+1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        string name;
        string description;
        int points;
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Convert.ToInt32(Console.ReadLine());
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Convert.ToInt32(Console.ReadLine());
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (var i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i+1}. {_goals[i].GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        var goalNum = Convert.ToInt32(Console.ReadLine());
        var goal = _goals[goalNum-1];
        var points = goal.RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        var filename = Console.ReadLine();

        using var file = new StreamWriter(filename);
        file.WriteLine(_score);
        foreach (var goal in _goals)
        {
            file.WriteLine(goal.GetStringRepresentation());
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        var filename = Console.ReadLine();

        Console.Write("This will overwrite your existing goals. Are you sure you want to continue? (y/N) ");
        var confirm = Console.ReadLine();
        if (confirm != "y")
        {
            Console.WriteLine("Aborting.");
            return;
        }

        _goals = [];

        var lines = File.ReadAllLines(filename);
        for (var i = 0; i < lines.Length; i++)
        {
            if (i == 0)
            {
                _score = Convert.ToInt32(lines[i]);
                continue;
            }

            var info = lines[i].Split(':');
            var parts = info[1].Split(',');
            switch (info[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[0], parts[1], Convert.ToInt32(parts[2]), Convert.ToBoolean(parts[3])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[0], parts[1], Convert.ToInt32(parts[2])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[0], parts[1], Convert.ToInt32(parts[2]), Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5])));
                    break;
            }
        }
    }
}