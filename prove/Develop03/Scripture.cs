public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new();
    private Random rng = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string everyWord in words)
        {
            Word word = new Word(everyWord);
            _words.Add(word);
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        int counter = 0;
        int index = 0;
        while (counter < numberToHide && !IsCompletelyHidden())
        {
            do
            {
                index = rng.Next(_words.Count);
            } while(_words[index].GetIsHidden());
            _words[index].Hide();
            counter++;
        }
    }
    public void GetDisplayText()
    {
        Console.Write(_reference.GetDisplayText());
        foreach(Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }
}