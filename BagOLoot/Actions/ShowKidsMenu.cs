using System;

namespace BagOLoot.Actions
{
    public class KidsMenu
    {
        public static Child Show (ChildRegister book)
        {
            Console.Clear();
            Console.WriteLine ("Choose child:");

            var children = book.GetChildren().ToArray();
            foreach (Child child in children)
            {
                Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
            }

            Console.Write ("> ");
            string childChoice = Console.ReadLine();
            return book.GetChild(children[int.Parse(childChoice)-1].name);
        }   
    }
}