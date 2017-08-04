using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AssignDeliveredChildren // 5. Child toy delivery complete
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      var children = book.GetChildren().ToArray();
      if (children.Length == 0)
      {
        PromptForAddChild.Prompt("You must first register a child and their toys before any toys can be delivered.");
        return;
      }
      var kid = KidsMenu.Show(book, "Which child had all of their toys delivered?");
      
      Console.WriteLine ($"Press Y to confirm that {kid.name}'s toys were all delivered.");
      Console.Write ("> ");
      string userResponse = Console.ReadLine();
      
      if (userResponse == "Y" || userResponse == "y")
      {
        kid.delivered = true;
      }
    }
  }
}
