using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

public class GoalManager
{

private List<Goal> _goals = new List<Goal>();
private int _score;


public GoalManager()
{
}


public void Start()
{
    List<string> menu = new List<string>{" 1. Create New Goal", " 2. List Goals", " 3. Save Goals", " 4. Load Goals", " 5. Record Event", " 6. Quit"};

        
    string user = "";
    while (user != "6")
        {
            DisplayPlayerInfo();
            
            Console.WriteLine("\nMenu Options: ");
            foreach(string m in menu)
            {
                Console.WriteLine(m);
            }
            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();
            Console.Clear();
            if (user == "1")
            {   
                CreateGoal();
            }

            else if (user == "2")
            {
                ListGoalDetails();
            }

            else if (user == "3")
            {
                SaveGoals();
            }

            else if (user == "4")
            {
                LoadGoals();
            }

            else if (user == "5")
            {
                RecordEvent();
            }
}
}

public void DisplayPlayerInfo()
{
    
    Console.WriteLine($"\nYour score is: {_score}");
}

public void ListGoalNames()
{
    Console.WriteLine("The goals are: ");
    foreach(Goal goal in _goals)
    {    
        Console.WriteLine($"{_goals.IndexOf(goal)+1}. {goal.GetName()}");
    }
}

public void ListGoalDetails()
{
    foreach(Goal goal in _goals)
    {
        Console.WriteLine($"{_goals.IndexOf(goal)+1}. {goal.GetDetailsString()}");
    }
}

public void CreateGoal()
{   
    List<string> goals = new List<string>{" 1. Simple Goal", " 2. Eternal Goal", " 3. Checklist Goal"};
    
    Console.WriteLine("The types of Goals are: ");
    foreach(string g in goals)
    {
        Console.WriteLine(g);
    }
    Console.Write("Whick type of goal would you like to create? ");
    string user = Console.ReadLine();

    Console.Write("What is the name of the goal? ");
    string newGoal = Console.ReadLine();
    Console.Write("What is a short description of it? ");
    string newDescription = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    string newPoint = Console.ReadLine();
    int newPoint1 = int.Parse(newPoint);

    if (user == "1")
    {
        SimpleGoal s1 = new SimpleGoal(newGoal, newDescription, newPoint1);
        _goals.Add(s1);
    }

    else if (user == "2")
    {
        EternalGoal e1 = new EternalGoal(newGoal, newDescription, newPoint1);
        _goals.Add(e1);
    }

    else if (user == "3")
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string newTarget = Console.ReadLine();
        int newTarget1 = int.Parse(newTarget);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string newBonus = Console.ReadLine();
        int bonus = int.Parse(newBonus);

        ChecklistGoal c1 = new ChecklistGoal(newGoal, newDescription, newPoint1, newTarget1, bonus);

        _goals.Add(c1);
    }
    

    
}

public void RecordEvent()
{
    Console.WriteLine("Which goal did you accomplish? \n");

    ListGoalNames();
    Console.WriteLine();
    string user = Console.ReadLine();
    int user1 = int.Parse(user);
    Goal goal = _goals[user1-1];  

    if (goal.IsComplete() == false)
    {
        goal.RecordEvent();
        _score += goal.GetPoints();

        Console.WriteLine($"\nCongratulations! You have earned {goal.GetPoints()} points!");

        if(goal.ToString() == "ChecklistGoal" && goal.IsComplete() == true)
        {
            _score += goal.GetBonus();
        }
    }

    
}

public void SaveGoals()
{
    Console.Write("What is the filename? ");
    string file = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        } 
}

public void LoadGoals()
{
    Console.Write("What is the filename? ");
    string file = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(file);

    int lines1 = int.Parse(lines[0]);    
    _score = lines1;

        foreach (string line in lines)
        {
            if(line != lines[0])
            {
                string[] split = line.Split("|");

                string name = split[1];
                string description = split[2];
                string points = split[3];
                int points1 = int.Parse(points);

                if(split[0] == "SimpleGoal")
                {
                    bool complete = bool.Parse(split[4]);
                    SimpleGoal s1 = new SimpleGoal(name, description, points1);

                    if(complete == true)
                    {
                        s1.RecordEvent();
                    }
                    _goals.Add(s1);

                }


                else if(split[0] == "EternalGoal")
                {   
                    EternalGoal e1 = new EternalGoal(name, description, points1);
                    _goals.Add(e1);
                }

                else if(split[0] == "ChecklistGoal")
                {   
                    string amount = split[4];
                    string target = split[5];
                    string bonus = split[6];
                    int amount1 = int.Parse(amount);
                    int target1 = int.Parse(target);
                    int bonus1 = int.Parse(bonus);

                    ChecklistGoal c1 = new ChecklistGoal(name, description, points1 ,target1, bonus1);

                    for (int i = 0; i < amount1; i++)
                    {
                        c1.RecordEvent();
                    }

                    _goals.Add(c1);

                }

            }
        }

}






























}