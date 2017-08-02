using System;
using System.Collections.Generic;
using System.Linq;


namespace BagOLoot.Actions
{
  public class RemoveToy // 3. Revoke toy from child
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      
      // Console.Clear();
      // Console.WriteLine 

      // var children = book.GetChildren().ToArray();
      // foreach (Child child in children)
      // {
      //     Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      // }

      // Console.Write ("> ");
      // string childChoice = Console.ReadLine();
      // Child kid = book.GetChild(children[int.Parse(childChoice)-1].name);
      var kid = KidsMenu.Show(book);

      Console.WriteLine ($"Choose toy to remove from {kid.name}'s Bag O' Loot:");

      // var toys = bag.GetToysForChild(children[int.Parse(childChoice)-1]).ToArray(); // return List of toys
      var toys = bag.GetToysForChild(kid).ToArray();
      
      foreach (Toy toy in toys)
      {
        Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
      }
      Console.Write ("> ");
      string toyChoice = Console.ReadLine();
      Toy thisToy = toys[int.Parse(toyChoice)-1];
      // bag.RevokeToy(kid, thisToy);
      bag.RevokeToy(thisToy);

      // why is this not printing ???
      Console.WriteLine($"{thisToy.name} has been removed from {kid.name}'s Bag O' Loot.");

      Console.WriteLine("Press <Enter> to return to Main Menu");
      Console.WriteLine ("> ");
      Console.ReadLine ();
      return;
    }
  }
}
