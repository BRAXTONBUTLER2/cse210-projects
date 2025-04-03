using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _creator;
    private int _duration;
    private List<Comment> _commentSection;

    public Video(string title, string creator, int duration)
    {
        _title = title;
        _creator = creator;
        _duration = duration;
        _commentSection = new List<Comment>();
    }

    public void AddComment(Comment newComment)
    {
        _commentSection.Add(newComment);
    }

    public int GetCommentCount()
    {
        return _commentSection.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Creator: {_creator}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine($"Total Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _commentSection)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }

        Console.WriteLine();
    }
}
