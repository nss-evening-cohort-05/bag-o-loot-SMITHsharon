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
      string childName = Console.ReadLine();
      Console.WriteLine($"childName :: {childName}");
      Console.WriteLine($"int.Parse(childName) :: {int.Parse(childName)}");
      
      // Child kid = book.GetChild(children[int.Parse(childName)-1]);
      Child kid = book.GetChild(children[int.Parse(childName)-1].name);
      // Console.WriteLine($"this :: {book.GetChild(children[int.Parse(childName)-1].name)}");
      Console.WriteLine($"this / 0 :: {book.GetChild(children[0].name)}");
      Console.WriteLine($"this / 1 :: {book.GetChild(children[1].name)}");
      Console.WriteLine($"kid :: {kid}");
      
      Console.WriteLine ($"Enter toy to add to {kid}'s Bag O' Loot:");
      Console.Write ("> ");
      string toyName = Console.ReadLine();
      bag.Add(toyName, kid);
    }
  }
}
