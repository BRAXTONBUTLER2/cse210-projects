using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunBreathingActivity()
    {
        RunActivityParentStart();
        PerformBreathingCycle();
        RunActivityParentEnd();
    }

    public void PerformBreathingCycle()
    {
        int sessionTime = GetUserSessionLengthInput() * 1000;
        int cycleDuration = 10000;
        int cycleCount = sessionTime / cycleDuration;

        for (int i = 0; i < cycleCount; i++)
        {
            Console.Write("Breathe in... ");
            CountUp();
            Console.WriteLine();
            
            Console.Write("Breathe out... "); 
            Countdown();
            Console.WriteLine();
        }
    }

    private void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void CountUp()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
