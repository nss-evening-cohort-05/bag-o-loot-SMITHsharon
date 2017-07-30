using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class CreateChild
  {
    public static void DoAction(ChildRegister registry)
    {
      Console.Clear();

      Console.WriteLine ("Enter child name");
      Console.Write ("> ");
      string childName = Console.ReadLine();
      if (childName != null)
      {
        Child childId = registry.AddChild(childName);
      }
    }
  }
}
