using System;

namespace BagOLoot.Actions
{
    public class PromptForAddChild
    {
        public static void Prompt (string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("Press <Enter> to return to Main Menu");
            Console.WriteLine ("> ");
            Console.ReadLine ();
            return;
        }   
    }
}