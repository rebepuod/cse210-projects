using System.IO;
using System.Reflection.Metadata.Ecma335;
public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    Entry newEntry = new Entry();

 

    public void AddEntry(Entry newEntry)
    {
        
        newEntry._entryText = Console.ReadLine();
        
         _entries.Add(newEntry);
            
        
    }

    public void DisplayAll()
    {
        
        foreach(Entry entry in _entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                // This is how the text is going in.
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }    
    }

    public void LoadFromFile(string file)
    {
       
        string[] lines = System.IO.File.ReadAllLines(file);
       
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
          
            
            newEntry._date = parts[0]; 
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            
            AddEntry(newEntry);                  
        }

    }

}