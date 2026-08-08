using System;

public class mathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;

    public mathAssignment(string _studentName, string _topic): base(_studentName)
    {
        _topic = _topic;
        
    }

    public string GetHomeworkList()
    {
        return _textbookSection;
    }

}