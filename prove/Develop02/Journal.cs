using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public Journal()
    {
    }

    public void AddEntry(Entry anEntry)
    {
        _entries.Add(anEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts [2];
            entry._feelingAtTheMoment = parts[3];
            _entries.Add(entry);
        }
    }
    
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._feelingAtTheMoment}");
        }
        }
    }
}