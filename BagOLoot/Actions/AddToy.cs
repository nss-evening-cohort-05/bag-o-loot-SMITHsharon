using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AddToy // 2. Assign toy to a child
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();

      var children = book.GetChildren().ToArray();
      
      if (children.Length == 0)
      {
        Console.WriteLine("You must first register a child before you can assign any toys.");
        Console.WriteLine("Press <Enter> to return to Main Menu");
        Console.WriteLine ("> ");
        Console.ReadLine ();
        return;
      }
      
      Console.WriteLine ("Assign toy to which child?");
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }
      
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
