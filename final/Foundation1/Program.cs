using System;
using System.Collections.Generic;

// I used the internet to help me come up with name ideas, I went with a video game theme

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        // First Video
        Video firstVideo = new Video("Top 10 Boss Fights of All Time", "GamingLegends", 720);
        firstVideo.AddComment(new Comment("PixelWarrior", "That final boss from Dark Souls still gives me nightmares!"));
        firstVideo.AddComment(new Comment("8BitKing", "Glad to see Sekiro made the list. Insane fight."));
        firstVideo.AddComment(new Comment("GameOverDude", "The music in these fights makes them even better!"));
        videoList.Add(firstVideo);

        // Second Video
        Video secondVideo = new Video("Speedrunning 101: Tricks and Glitches", "GlitchMaster", 600);
        secondVideo.AddComment(new Comment("FramePerfect", "Tried this in Mario 64, works like a charm!"));
        secondVideo.AddComment(new Comment("LagSkip", "Love how people find these tricks decades later."));
        secondVideo.AddComment(new Comment("CheckpointGuy", "Still trying to learn the first trick lol."));
        videoList.Add(secondVideo);

        // Third Video
        Video thirdVideo = new Video("History of Open World Games", "GameTimeHistory", 900);
        thirdVideo.AddComment(new Comment("QuestHunter", "Crazy to see how far open worlds have come!"));
        thirdVideo.AddComment(new Comment("LoadingScreen", "Skyrim is still the king of open-world RPGs."));
        thirdVideo.AddComment(new Comment("SideQuestLord", "They better mention Red Dead Redemption 2."));
        videoList.Add(thirdVideo);

        // Fourth Video
        Video fourthVideo = new Video("The Evolution of Graphics in Gaming", "VisualGamer", 480);
        fourthVideo.AddComment(new Comment("RayTracingRex", "The leap from PS1 to PS2 was mind-blowing."));
        fourthVideo.AddComment(new Comment("HDGamer", "Still remember the first time I saw Crysis on max settings."));
        fourthVideo.AddComment(new Comment("RetroPlayer", "Games today look insane, but nothing beats old-school pixel art."));
        videoList.Add(fourthVideo);

        foreach (Video vid in videoList)
        {
            vid.DisplayInfo();
        }
    }
}
