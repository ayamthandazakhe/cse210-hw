
using System.Linq;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Check whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Display the word or underscores
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return string.Concat(
                _text.Select(character =>
                    char.IsLetter(character) ? '_' : character)
            );
        }

        return _text;
    }
}
