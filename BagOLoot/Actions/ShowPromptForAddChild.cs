using System;

namespace BagOLoot.Actions
{
    public class CheckForChildren
    {
        public static bool Prompt (int arrLength, string prompt)
        {
            // checks to make sure there are Children, 
            // before anything can be done w toys
            if (arrLength == 0) // there are no kids
            {
                Console.WriteLine(prompt);
                Console.WriteLine("Press <Enter> to return to Main Menu");
                Console.WriteLine ("> ");
                Console.ReadLine ();
                return false;
            }
            else
            {
                return true; // there are kids
            }
        }   
    }
}