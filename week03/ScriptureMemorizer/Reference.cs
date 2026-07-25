using System;
using System.Security.Cryptography;

public class Reference
{
    private string _book;

    private int _chapter;

    private int _verse;

    private int _endVerse;

    public Reference(string Book, int Chapter, int Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _verse = Verse; 
        _endVerse = Verse;
    }

    public Reference(string Book, int Chapter, int Verse, int endVerse)
    {
        _book = Book;
        _chapter = Chapter;
        _verse = Verse; 
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if(_verse == _endVerse)
        {
            return $"{_book}{_chapter}:{_verse}";
        }
        else
        {
            return $"{_book}{_chapter}:{_verse}-{_endVerse}";
        }
    }
}