using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class CreateChild // 1. Add a child
  {
    public static void DoAction(SantasNiceList registry)
    {
      Console.Clear();

      Console.WriteLine ("Enter child name:");
      Console.Write ("> ");
      string childName = Console.ReadLine();
      if (childName != null)
      {
        Child childId = registry.AddChild(childName);
      }
      return;
    }
  }
}
