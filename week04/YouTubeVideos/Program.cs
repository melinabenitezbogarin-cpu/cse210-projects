using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();

        Video v1 = new Video("Morning Routine at 5 am", "Marys vlogs",600);
        v1.AddComment(new Comment("Mary", "Great way to start your day!"));
        v1.AddComment(new Comment("Marie", "I loved how you prepare breakfast before going to the gym."));
        v1.AddComment(new Comment("Laura", "Great organization"));
        _videoList.Add(v1);

        Video v2 = new Video("Phyton Tutorial", "Program Family",1500);
        v2.AddComment(new Comment("John", "Thank you so much for this help"));
        v2.AddComment(new Comment("David", "What happend if my terminal doesn´t work?"));
        v2.AddComment(new Comment("Sam", "This is a really basic program"));
        _videoList.Add(v2);

        Video v3 = new Video("House Tour", "Lili Designs",3000);
        v3.AddComment(new Comment("Lilian", "I enjoy the way that you design the living room"));
        v3.AddComment(new Comment("Luisa", "How can I contact you?"));
        v3.AddComment(new Comment("Fran", "The island of the kitchen has wood?"));
        _videoList.Add(v3);

        foreach (Video video in _videoList)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLegth()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentsNumber()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: \"{comment.GetText()}\"");
            }

        }

    }
}