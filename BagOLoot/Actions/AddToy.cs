using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AddToy // 2. Assign toy to a child
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Assign toy to which child?");

      var children = book.GetChildren().ToArray();
      // Console.WriteLine($"children.Length :: {children.Length}");
      // if (children.Length>1)
      // {
      //   Console.WriteLine ("Choose child");
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }
    // }
    //   else
    //   {
    //     Console.WriteLine("You must first register a child before you can assign any toys.");
    //     return;
    //   }

      Console.Write ("> ");
      string childChoice = Console.ReadLine();
      
      Child kid = book.GetChild(children[int.Parse(childChoice)-1].name);
      
      Console.WriteLine ($"Enter toy to add to {kid.name}'s Bag O' Loot:");
      Console.Write ("> ");
      string toyName = Console.ReadLine();
      bag.Add(toyName, kid);
    }
  }
}
