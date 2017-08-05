using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class ListYuletimeDeliveryReport // 6. Yuletime Delivery Report
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      var children = book.GetChildren().ToArray();
      bool thereAreKidsToList = true;
      
      thereAreKidsToList = CheckForChildren.Prompt
                           (children.Length, 
                           "You must first register a child and their toys before any toys can be delivered.");
      
      if (thereAreKidsToList)
      {
        int count = 0;
        Console.Clear();
        Console.WriteLine("Yuletime Delivery Report");
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%");

        foreach (Child child in children)
        {
            if (child.delivered)
            {
              var toys = bag.GetToysForChild(child).ToArray(); // return List of toys
              
              Console.WriteLine($"{child.name}'s toys delivered:");
              foreach (Toy toy in toys)
              {
                Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
              }
              count += 1;
            }
        }
        if (count == 0)
        {
          Console.WriteLine($"No toys have been delivered yet.");
        }
      }
      
      PauseMessage.DisplayPrompt();
      return;
    }
  }
}
