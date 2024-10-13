using System;
using System.Collections.Generic;

// Comment class definition
public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}

// Video class definition
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public override string ToString()
    {
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\n";
    }
}

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 300);
        Video video2 = new Video("Video 2", "Author 2", 240);
        Video video3 = new Video("Video 3", "Author 3", 180);
        Video video4 = new Video("Video 4", "Author 4", 360);

        // Add comments to videos
        video1.AddComment(new Comment("Ugochukwu Onunkwo", "Great video!"));
        video1.AddComment(new Comment("Adaobi Onunkwo", "Love it!"));
        video1.AddComment(new Comment("Gordon Hinckley", "Excellent!"));
        video1.AddComment(new Comment("Olamilekan Lawal", "Fantastic!"));

        video2.AddComment(new Comment("Joy Onunkwo", "Good job!"));
        video2.AddComment(new Comment("Victor Enyeribe", "Well done!"));
        video2.AddComment(new Comment("Harold Lee", "Nice!"));
        video2.AddComment(new Comment("John Taylor", "Awesome!"));

        video3.AddComment(new Comment("Obinna Onunkwo", "Excellent work!"));
        video3.AddComment(new Comment("Emma Smith", "Great effort!"));
        video3.AddComment(new Comment("Helvécio Martins", "Good stuff!"));
        video3.AddComment(new Comment("Uchenna Onunkwo", "Well done!"));

        video4.AddComment(new Comment("Chinedu Onunkwo", "Fantastic video!"));
        video4.AddComment(new Comment("Joseph Smith", "Love it!"));
        video4.AddComment(new Comment("Joseph Sitati", "Excellent!"));
        video4.AddComment(new Comment("Brigham Young", "Great job!"));

        // Create list of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine(video.ToString());
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(comment.ToString());
            }
            Console.WriteLine();
        }
    }
}