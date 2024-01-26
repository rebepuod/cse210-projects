using System.IO; 
public class Journal

{

    public List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry newEntry)
    {
         
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_entries);
        }    
    }

    public void LoadFromFile(string file)
    {

    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
}

    }

}