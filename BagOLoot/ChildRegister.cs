using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class SantasNiceList
    {
        private List<Child> _children = new List<Child>();
        public Child AddChild (string childName) 
        {
            var child = new Child()
                {
                    name = childName,
                    delivered = false
                };
            _children.Add(child);

            return child;
        }

        public List<Child> GetChildren () => _children;

        public Child GetChild (string name) =>  _children.SingleOrDefault(kid => kid.name == name);
        
    }
}
