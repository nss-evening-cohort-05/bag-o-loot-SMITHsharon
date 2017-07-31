using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class ListDeliveredChildren // 5. Child toy delivery complete
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Which child had all of their toys delivered?");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          if (child.delivered)
          {
            Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
          }
      }

      // Console.Write ("> ");
      // string childName = Console.ReadLine();
      // Child kid = book.GetChild(children[int.Parse(childName)-1].name);
      
      // Console.WriteLine ($"Enter toy to add to {childName}'s Bag O' Loot:");
      // Console.Write ("> ");
      // string toyName = Console.ReadLine();
      // bag.Add(toyName, kid);
    }
  }
}
