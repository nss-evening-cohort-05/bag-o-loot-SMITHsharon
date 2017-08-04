using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class ReviewToyList // 4. Review child's toy list
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      var children = book.GetChildren().ToArray();
      if (children.Length == 0)
      {
        PromptForAddChild.Prompt("You must first register a child and their toys before you view the toy list.");
        return;
      }
      var kid = KidsMenu.Show(book, "View Bag o' Loot for which child:");

      var toys = bag.GetToysForChild(kid).ToArray();
      
      Console.WriteLine ($"{kid.name}'s Bag O' Loot:");

      foreach (Toy toy in toys)
      {
        Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
      }

      Console.WriteLine("Press <Enter> to return to Main Menu");
      Console.WriteLine ("> ");
      Console.ReadLine ();
      return;
      
    }
  }
}
