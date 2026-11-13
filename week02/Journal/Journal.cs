public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //public string _addedDate;
    //public string _addedPrompt;
    //public string _addedEntry;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry(); 
        }
    }

    public void SaveToFile(string file)
    {
        
    string filename = "";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Saving {filename}...");
        }
    }

    public void LoadFromFile(string file)
    {
        string filename = "";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
{
        string[] parts = line.Split(",");

        string _promptText = parts[0];
        string _date = parts[1];
        string _entryText = parts[2];
}
    }
}