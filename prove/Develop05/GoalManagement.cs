using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet.");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    public void RecordGoalProgress(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid selection. Try again.");
            return;
        }

        _goals[goalIndex].RecordProgress();
        _totalScore = CalculateTotalScore();
        Console.WriteLine($"New Total Score: {_totalScore} points!");

        SaveGoals("goals.txt");

        DisplayGoals();
    }

    private int CalculateTotalScore()
    {
        int total = 0;
        foreach (Goal goal in _goals)
        {
            total += goal.GetEarnedPoints();
        }
        return total;
    }

    public void DisplayTotalScore()
    {
        Console.WriteLine($"\nTotal Score: {_totalScore} points");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointsWorth()}|{simpleGoal.IsComplete()}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointsWorth()}|{checklistGoal.GetTimesCompleted()}|{checklistGoal.GetTargetCount()}|{checklistGoal.GetBonusPoints()}");
                }
                else
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointsWorth()}");
                }
            }
        }
        Console.WriteLine("Goals saved successfully to " + filename);
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                if (parts.Length < 4)
                {
                    Console.WriteLine("Skipping invalid goal entry.");
                    continue;
                }

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                if (!int.TryParse(parts[3], out int pointsWorth))
                {
                    Console.WriteLine("Skipping entry due to invalid point value.");
                    continue;
                }

                try
                {
                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = parts.Length > 4 && bool.TryParse(parts[4], out bool parsedComplete) && parsedComplete;
                            _goals.Add(new SimpleGoal(name, description, pointsWorth, isComplete));
                            break;

                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, pointsWorth));
                            break;

                        case "ChecklistGoal":
                            if (parts.Length < 7 ||
                                !int.TryParse(parts[4], out int timesCompleted) ||
                                !int.TryParse(parts[5], out int targetCount) ||
                                !int.TryParse(parts[6], out int bonusPoints))
                            {
                                Console.WriteLine("Skipping invalid ChecklistGoal entry.");
                                continue;
                            }

                            _goals.Add(new ChecklistGoal(name, description, pointsWorth, bonusPoints, targetCount, timesCompleted));
                            break;

                        default:
                            Console.WriteLine("Unknown goal type found, skipping entry.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing goal entry: {ex.Message}");
                }
            }
        }

        _totalScore = CalculateTotalScore();
        Console.WriteLine("Goals loaded successfully!");
        DisplayTotalScore();
        DisplayGoals();
    }
}
