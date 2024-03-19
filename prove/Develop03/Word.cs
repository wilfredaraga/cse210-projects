public class Word
{
    private string _text;
    private string _hiddenText;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        for(int i =0; i < _text.Length; i++)
        {
            _hiddenText += "_";
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? _hiddenText : _text;
    }
}