using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        Boolean quit = false;
        Journal anEntry = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());

            
            if (choice == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                prompt._prompts.Add("Who was the most interesting person I interacted with today?");
                prompt._prompts.Add("What was the best part of my day?");
                prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
                prompt._prompts.Add("What was the strongest emotion I felt today?");
                prompt._prompts.Add("If I had one thing I could do over today, what would it be?");

                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string answer = Console.ReadLine();
                /* I added this code to ask what the user is feeling at the time he/she is writing in
                the journal. I also added this to their entry and will save also in the file if they
                choose to save their entry. It will also show to their journal if they choose to display
                it. */
                Console.Write("What are you feeling right now? ");
                string feeling = Console.ReadLine();

                DateTime theCurrentDate = DateTime.Now;
                string dateText =theCurrentDate.ToShortDateString();
                Entry write = new Entry();
                write._date = dateText;
                write._promptText = randomPrompt;
                write._entryText = answer;
                write._feelingAtTheMoment = feeling.ToLower();

                anEntry.AddEntry(write);

                quit = false;
            }
            else if (choice == 2)
            {
                anEntry.DisplayAll();
                
                quit = false;
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is filename?");
                string filename = Console.ReadLine();
                anEntry.LoadFromFile(filename);

                quit = false;
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is filename?");
                string filename = Console.ReadLine();
                anEntry.SaveToFile(filename);

                quit = false;
            }
            else
            {
                quit = true;
            }

        } while (!quit);

        

    }
}