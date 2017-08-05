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
            // Arrange
            string toyName = "bicycle";
            Child kid = _book.AddChild("Sean");

            // Act
            Toy toy = _register.Add(toyName, kid);

            // Assert
            Assert.Equal(toy.name, toyName);
        }


        [Fact]
        public void GetToyListForChild()
        {
            // Arrange
            Child kid = _book.AddChild("Sean");
            string toy1 = "bicycle";
            string toy2 = "laptop";
            string toy3 = "other stuff";
            _register.Add(toy1, kid);
            _register.Add(toy2, kid);
            _register.Add(toy3, kid);
            
            // Act
            List<Toy> result = _register.GetToysForChild(kid);
            Toy toyObject1 = result[0];
            Toy toyObject2 = result[1];
            Toy toyObject3 = result[2];

            // Assert
            Assert.IsType<List<Toy>>(result);
            Assert.True(toyObject1.name == "bicycle");
            Assert.True(toyObject2.name == "laptop");
            Assert.True(toyObject3.name == "other stuff");
        }


        [Fact]
        public void RevokeToyFromChild()
        {
            // Arrange
            Child kid = _book.AddChild("Sean");
            string toy1 = "bicycle";
            string toy2 = "laptop";
            string toy3 = "other stuff";
            _register.Add(toy1, kid);
            _register.Add(toy2, kid);
            _register.Add(toy3, kid);
            List<Toy> toyList = _register.GetToysForChild(kid);
            Toy ToyToRevoke = toyList[1]; // toy2
            
            // Act
            _register.RevokeToy(ToyToRevoke);
            List<Toy> result = _register.GetToysForChild(kid);
            Toy toyObject1 = result[0];
            Toy toyObject2 = result[1];

            // Assert
            // Assert.DoesNotContain(result, ToyToRevoke);
            Assert.True(toyObject1.name == "bicycle");
            Assert.True(toyObject2.name == "other stuff");
        }
    }
}
