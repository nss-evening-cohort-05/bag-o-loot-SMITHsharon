using System;
using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
  public class SantasToyBag
  {
    private List<Toy> _toys = new List<Toy>();

    public Toy Add(string toy, Child child)
    {
      // Create new toy instance
      Toy newToy = new Toy()
      {
        name = toy,
        child = child
      };

      // Add to private collection
      _toys.Add(newToy);

      return newToy;
    }

    public void RevokeToy(Toy toy)
    {
      _toys.Remove(toy);
    }

    public List<Toy> GetToysForChild(Child kid)
    {
      // use LINQ to return the toy list for a particular Child
      var kidsToys = 
        from toy in _toys
        where toy.child == kid
        select toy;

      // kidsToys = _toys.Where(Toy => Toy.child == kid);

      return kidsToys.ToList();
    }
  }
}
