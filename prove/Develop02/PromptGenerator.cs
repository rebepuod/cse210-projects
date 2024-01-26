using System.ComponentModel;

public class PromptGenerator
{

    public List<string> _prompts = new List<string>();

    

    public string GetRandomPrompt()
    {
      Random randomGenerator = new Random();
      int number = randomGenerator.Next(0, 6);
    
      for (int i = 0; i <= 0; i ++)
        {
          Console.WriteLine(_prompts[number]);        
        }
      return "";             
    }
}