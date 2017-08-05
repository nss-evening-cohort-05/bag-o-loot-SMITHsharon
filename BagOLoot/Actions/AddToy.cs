using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AddToy // 2. Assign toy to a child
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      Console.Clear();

      var children = book.GetChildren().ToArray();
      bool thereAreKidsToList = true;

      thereAreKidsToList = CheckForChildren.Prompt
                           (children.Length, 
                           "You must first register a child before you can assign any toys.");
      
      if (thereAreKidsToList)
      {
        var kid = KidsMenu.Show(book, "Assign toy to which child:");

        Console.WriteLine ($"Enter toy to add to {kid.name}'s Bag O' Loot:");
        Console.Write ("> ");
        string toyName = Console.ReadLine();
        bag.Add(toyName, kid);
      }
      return;
    }
  }
}
