using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class ListYuletimeDeliveryReport // 6. Yuletime Delivery Report
  {
    public static void DoAction(SantasToyBag bag, SantasNiceList book)
    {
      Console.Clear();
      Console.WriteLine("Yuletime Delivery Report");
      Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%");

      var children = book.GetChildren().ToArray();
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
          }
      }
      Console.WriteLine("Press <Enter> to return to Main Menu");
      Console.WriteLine ("> ");
      Console.ReadLine ();
      return;
    }
  }
}
