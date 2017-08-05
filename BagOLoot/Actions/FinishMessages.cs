using System;

namespace BagOLoot.Actions
{
    public class PauseMessage
    {
        public static void DisplayPrompt()
        {
            Console.WriteLine("Press <Enter> to return to Main Menu");
            Console.WriteLine("> ");
            Console.ReadLine();
        }
    }
}