using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AssignDeliveredChildren // 5. Child toy delivery complete
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {Console.Clear();
      Console.WriteLine ("Which child had all of their toys delivered?");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childChoice = Console.ReadLine();
      if (childChoice != null)
      {
        Child kid = book.GetChild(children[int.Parse(childChoice)-1].name);
      
        Console.WriteLine ($"Press Y to confirm that {kid.name}'s toys were all delivered.");
        Console.Write ("> ");
        string userResponse = Console.ReadLine();
        
        if (userResponse == "Y" || userResponse == "y")
        {
          kid.delivered = true;
        }
      }
        // else 
        // {
      return;
        // }
    }
  }
}
