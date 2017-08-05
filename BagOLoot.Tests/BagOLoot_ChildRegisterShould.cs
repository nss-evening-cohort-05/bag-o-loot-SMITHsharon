using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class ChildRegisterShould
    {
        private readonly SantasNiceList _register;

        public ChildRegisterShould()
        {
            _register = new SantasNiceList();
        }

        [Theory] // Arrange
        [InlineData("Sarah")]
        [InlineData("Jamal")]
        [InlineData("Kelly")]
        public void AddChildren(string child)
        {
            // Act
            var result = _register.AddChild(child);

            // Assert
            Assert.True(result != null);
        }


        [Fact]
        public void ReturnListOfChildren()
        {
            // Arrange
            _register.AddChild("Svetlana");

            // Act
            var result = _register.GetChildren();

            // Assert
            Assert.IsType<List<Child>>(result);
            Assert.True(result.Count > 0);
        }


        [Fact]
        public void GetAChild()
        {
            // Arrange
            var created = _register.AddChild("Svetlana");

            // Act
            Child svetlana = _register.GetChild("Svetlana");

            // Assert
            Assert.True(created.name == svetlana.name);
        }


        [Fact]
        public void SetDeliveredStatusForChild() 
        {
            // Arrange
            var created = _register.AddChild("Sean");
            Child sean = _register.GetChild("Sean");

            // Act
            _register.SetDelivered (sean);

            // Assert
            Assert.Equal(sean.delivered, true);
        }
    }
}
