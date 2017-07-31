using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class ListYuletimeDeliveryReport // 6. Yuletime Delivery Report
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
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
            // var toys = bag.GetToysForChild(children[int.Parse(childName)-1]).ToArray(); // return List of toys

            Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
            foreach (Toy toy in toys)
            {
              Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
            }
          }
      }
    }
  }
}
