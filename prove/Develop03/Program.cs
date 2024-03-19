using System;

class Program
{
    static void Main(string[] args)
    {
        //Will create a list of scripture passages. Then will prompt a random scripture passage to memorize.
        List<Scripture> scriptures= new List<Scripture>();

        string scripture1Content = "Trust in the Lord with all your heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.";
        Scripture scripture1 = new Scripture(new Reference("Proverbs", 5, 3, 5), scripture1Content);
        scriptures.Add(scripture1);

        string scripture2Content = "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture2 = new Scripture(new Reference("John", 3, 16), scripture2Content);
        scriptures.Add(scripture2);
        
        string scripture3Content = "Nevertheless neither is the man without the woman, neither the woman without the man, in the Lord.";
        Scripture scripture3 = new Scripture(new Reference("1 Corinthians", 11, 11), scripture3Content);
        scriptures.Add(scripture3);

        string scripture4Content = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him; but let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.";
        Scripture scripture4 = new Scripture(new Reference("James", 1, 5, 6), scripture4Content);
        scriptures.Add(scripture4);

        string scripture5Content = "Who shall ascend into the hill of the Lord? or who shall stand in his holy place?; he that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.";
        Scripture scripture5 = new Scripture(new Reference("Psalm", 24, 3, 4), scripture5Content);
        scriptures.Add(scripture5);
        
        Random randomGeneratorPrompt = new();
        int randomScriptureIndex = randomGeneratorPrompt.Next(scriptures.Count);
        

        // Ask the user for how many words they want to hide at a time.
        Console.Write("How many words would you like to hide at a time? ");
        int hideWord = int.Parse(Console.ReadLine());

        do
        {
            Console.Clear();
            scriptures[randomScriptureIndex].GetDisplayText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            scriptures[randomScriptureIndex].HideRandomWords(hideWord);
        } while (!scriptures[randomScriptureIndex].IsCompletelyHidden());
    }
}