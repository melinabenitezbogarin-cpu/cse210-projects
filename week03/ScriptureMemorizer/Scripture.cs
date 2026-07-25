using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');

        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }    
    }

    public void HideVerseWords(int hideNumber)
    {
        Random random = new Random();

        for (int i = 0; i < hideNumber; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
        
    }

    public string GetDisplayText()
    {
        string scriptText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            scriptText += word.GetDisplayText() + " ";
        }

        return scriptText.Trim();
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

}
 