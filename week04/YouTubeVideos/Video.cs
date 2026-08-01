using System;

class Video
{
    private string _title;
    private string _author;
    private int _legth;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int legth)
    {
        _title = title;
        _author = author;
        _legth = legth;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentsNumber()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLegth()
    {
        return _legth;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}
