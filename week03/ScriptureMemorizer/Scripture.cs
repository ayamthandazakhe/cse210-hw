
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Display the scripture reference and text
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        string scriptureText = string.Join(
            " ",
            _words.Select(word => word.GetDisplayText())
        );

        return referenceText + " " + scriptureText;
    }

    // Hide a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        List<Word> availableWords = _words
            .Where(word => !word.IsHidden())
            .ToList();

        int count = Math.Min(numberToHide, availableWords.Count);

        for (int i = 0; i < count; i++)
        {
            int randomIndex = _random.Next(availableWords.Count);

            availableWords[randomIndex].Hide();

            availableWords.RemoveAt(randomIndex);
        }
    }

    // Check whether all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
