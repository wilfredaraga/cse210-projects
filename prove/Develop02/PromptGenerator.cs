public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, (_prompts.Count - 1));
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}