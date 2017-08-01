using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class ReviewToyList // 4. Review child's toy list
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("View Bag o' Loot for which child?");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childChoice = Console.ReadLine();
      Child kid = book.GetChild(children[int.Parse(childChoice)-1].name);
      
      Console.WriteLine ($"{kid.name}'s Bag O' Loot:");

      var toys = bag.GetToysForChild(children[int.Parse(childChoice)-1]).ToArray(); // return List of toys
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
