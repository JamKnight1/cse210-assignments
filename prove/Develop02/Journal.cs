public class Journal {

    public List<Entry> _entries = new List<Entry>();
    public string _fileName;
   
    public void AddEntry(){
        Entry entry = new Entry();
        entry.WriteEntry();
        _entries.Add(entry);
    }

    public void DisplayJournal(){
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal(){
        Console.WriteLine("What is the name of this journal?");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._response);
                outputFile.WriteLine(entry._goal);
            }
        }
    }

    public void LoadJournal(){
        Console.WriteLine("What is the name of the journal you would like to load?");
        _fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        for (int i = 0; i < lines.Length; i += 3)
        {
            Entry entry = new Entry();
            entry._date = lines[i];
            entry._prompt = lines[i + 1];
            entry._response = lines[i + 2];
            entry._goal = lines[i + 3];
            _entries.Add(entry);
        }
    }

}