using System;
using System.Collections.Generic;
using System.Linq;


namespace BagOLoot.Actions
{
  public class RevokeToy // 3. Revoke toy from child
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      var children = book.GetChildren().ToArray();
      if (children.Length == 0)
      {
        PromptForAddChild.Prompt("You must first register a child before you can revoke any toys.");
        return;
      }
      var kid = KidsMenu.Show(book, "Remove toy from which child:");

      Console.WriteLine ($"Choose toy to remove from {kid.name}'s Bag O' Loot:");

      var toys = bag.GetToysForChild(kid).ToArray();
      // DEBUG THIS ... 
      // if (toys[0] == null)
      // { 
      //   Console.WriteLine($"{kid.name} does not have any toys that can be removed.");
      //   Console.WriteLine("Press <Enter> to return to Main Menu");
      //   Console.WriteLine ("> ");
      //   Console.ReadLine ();
      //   return;
      // }
      foreach (Toy toy in toys)
      {
        Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
      }
      Console.Write ("> ");
      string toyChoice = Console.ReadLine();
      Toy chosenToy = toys[int.Parse(toyChoice)-1];
      bag.RevokeToy(chosenToy);

      Console.WriteLine($"{chosenToy.name} has been removed from {kid.name}'s Bag O' Loot.");

      Console.WriteLine("Press <Enter> to return to Main Menu");
      Console.WriteLine ("> ");
      Console.ReadLine ();
      return;
    }
  }
}
