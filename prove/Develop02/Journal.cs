using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = [];

    public void AddEntry(Entry entry)
    {
        entry._date = DateTime.Now.ToShortDateString();
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save(String file)
    {
        // Original "Comma" Seperated Values file saving
        // using var writer = new StreamWriter(file);
        // foreach (Entry entry in _entries)
        // {
        //     writer.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
        // }

        // New JSON file saving
        using var writer = new StreamWriter(file);
        var json = JsonSerializer.Serialize(_entries);
        writer.WriteLine(json);
    }

    public void Load(String file)
    {
        // Original "Comma" Seperated Values file loading
        // _entries = [];
        // string[] lines = File.ReadAllLines(file);
        // foreach (string line in lines)
        // {
        //     string[] fields = line.Split("~|~");
        //     Entry entry = new Entry
        //     {
        //         _date = fields[0],
        //         _prompt = fields[1],
        //         _response = fields[2]
        //     };
        //     _entries.Add(entry);
        // }

        // New JSON file loading
        var json = File.ReadAllText(file);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json);
    }
}