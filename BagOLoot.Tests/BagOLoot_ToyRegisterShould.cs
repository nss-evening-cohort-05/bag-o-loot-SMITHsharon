using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyRegisterShould
    {
        private readonly SantasToyBag _register;
        private readonly SantasNiceList _book;

        public ToyRegisterShould()
        {
            _register = new SantasToyBag();
            _book = new SantasNiceList();
        }

        [Fact]
        public void AddToy()
        {
            // Create a child
            Child kid = _book.AddChild("Terell");

            // Add a toy for the child
            Toy toy = _register.Add("Silly Putty", kid);
            Assert.True(toy != null);
        }

        // [Fact]
        // public void AddToyToList()
        // {
        //     Child kid = _book.AddChild("Terell");
        //     Toy toy = _register.Add("Silly Putty", kid);
        //     List<Toy> toysForTerell = _register.GetToysForChild(kid);
        //     Assert.True(toysForTerell.Count>0);
        // }

        [Fact]
        public void RevokeToyFromChild()
        {
            // Arrange
            Child kid = _book.AddChild("Terell");
            Toy toy = _register.Add("Silly Putty", kid);

            // Act
            _register.RevokeToy(toy);
            List<Toy> toysForTerell = _register.GetToysForChild(kid);

            // Assert
            Assert.DoesNotContain(toy, toysForTerell);
        }

        // [Fact]
        // public void ReviewToyListForChildren()
        // {
            // Arrange
        //     Child child1 = _book.AddChild("Sean");
        //     Child child2 = _book.AddChild("Heather");
        //     Toy toy1 = _register.Add("Bicycle", child1);
        //     Toy toy2 = _register.Add("Flute", child2);
        //     Toy toy3 = _register.Add("Laptop", child1);

            // Act

            // Assert
        //     //Assert.Count(); 
        // }

        // [Fact]
        // public void ListAllofChildsToys()
        // {
            // Arrange
        //     Child child1 = _book.AddChild("Sean");
        //     Child child2 = _book.AddChild("Heather");
        //     Toy toy1 = _register.Add("Bicycle", child1);
        //     Toy toy2 = _register.Add("Laptop", child1);
        //     Toy toy3 = _register.Add("Flute", child2);

            // Act
        //     List<Toy> toysForKiddo = _register.GetToysForChild(child1);

            // Assert
        //     Assert.Contains("Ball", "Truck");
        //     // Assert.Count(); 
        // }
    }
}
