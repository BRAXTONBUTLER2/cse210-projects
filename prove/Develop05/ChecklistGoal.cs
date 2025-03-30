public class ChecklistGoal : Goal
{
    private int _completionPoints;
    private int _rewardBonus;
    private int _completionTarget;
    private int _currentCompletions;

    public ChecklistGoal(string name, string description, int completionPoints, int rewardBonus, int completionTarget, int currentCompletions = 0) 
        : base(name, description, completionPoints)
    {
        _completionPoints = completionPoints;
        _rewardBonus = rewardBonus;
        _completionTarget = completionTarget;
        _currentCompletions = currentCompletions;
    }

    public int GetCurrentCompletions() => _currentCompletions;
    public int GetCompletionTarget() => _completionTarget;
    public int GetRewardBonus() => _rewardBonus;
    public void SetCurrentCompletions(int count) => _currentCompletions = count;

    public override void RecordProgress()
    {
        if (_currentCompletions < _completionTarget)
        {
            _currentCompletions++;
            AddPoints(_completionPoints);
            Console.WriteLine($"Progress recorded for '{GetName()}'. ({_currentCompletions}/{_completionTarget})");

            if (_currentCompletions == _completionTarget)
            {
                AddPoints(_rewardBonus);
                Console.WriteLine($"Completed! Bonus {_rewardBonus} points awarded!");
            }
        }
        else
        {
            Console.WriteLine($"'{GetName()}' is already completed.");
        }
    }

    public override string DisplayStatus()
    {
        return _currentCompletions >= _completionTarget
            ? $"✅ {GetName()} - {GetDescription()} ({GetPointsWorth()} Points) (Completed {_currentCompletions}/{_completionTarget})"
            : $"⬜ {GetName()} - {GetDescription()} ({GetPointsWorth()} Points) (Completed {_currentCompletions}/{_completionTarget})";
    }

    public bool IsComplete()
    {
        return _currentCompletions >= _completionTarget;
    }
}
