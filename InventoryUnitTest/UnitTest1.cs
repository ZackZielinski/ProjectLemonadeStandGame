using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using System.IO;

namespace InventoryUnitTest
{
    [TestClass]
    public class PlayerNameTest
    {
        [TestMethod]
        public void DoesPlayerNameHoldAValue()
        {

            //Arrange
            Player person = new Player();
            PrivateObject obj = new PrivateObject(person);
            string input = "Zack";
            string ExpectedResult = "Zack";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            //Act

            Convert.ToString(obj.Invoke("GetPlayerName"));

            //Assert
            Assert.AreEqual(ExpectedResult, person.Name);
        }

        [TestMethod]
        public void HasPlayerHaveMoneyFromBuyingLemons()
        {

            //Arrange
            Player person = new Player();
            Store shop = new Store();
            PrivateObject obj = new PrivateObject(shop);
            string input = "10";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            
            double ExpectedResult = person.Money - (shop.LemonPrice * int.Parse(input));
            double ActualResult;

            //Act
            obj.Invoke("PurchaseLemons", shop.Product, person.backpack, person);
            ActualResult = person.Money;

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void HasPlayerHaveMoneyFromBuyingSugar()
        {

            //Arrange
            Player person = new Player();
            Store shop = new Store();
            PrivateObject obj = new PrivateObject(shop);
            string input = "10";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            double ExpectedResult = person.Money - (shop.SugarPrice * int.Parse(input));
            double ActualResult;

            //Act
            obj.Invoke("PurchaseSugar", shop.Product, person.backpack, person);
            ActualResult = person.Money;

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void HasPlayerHaveMoneyFromBuyingIce()
        {

            //Arrange
            Player person = new Player();
            Store shop = new Store();
            PrivateObject obj = new PrivateObject(shop);
            string input = "10";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            double ExpectedResult = person.Money - (shop.IcePrice * int.Parse(input));
            double ActualResult;

            //Act
            obj.Invoke("PurchaseIce", shop.Product, person.backpack, person);
            ActualResult = person.Money;

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void HasPlayerHaveMoneyFromBuyingCups()
        {

            //Arrange
            Player person = new Player();
            Store shop = new Store();
            PrivateObject obj = new PrivateObject(shop);
            string input = "10";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            double ExpectedResult = person.Money - (shop.CupPrice * int.Parse(input));
            double ActualResult;

            //Act
            obj.Invoke("PurchaseCups", shop.Product, person.backpack, person);
            ActualResult = person.Money;

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        
        [TestMethod]
        public void DoesPlayerLoseLemonsFromInventory()
        {

            //Arrange
            Inventory backpack = new Inventory();
            Recipe ingredients = new Recipe();
            PrivateObject obj = new PrivateObject(backpack);
            backpack.LemonInventory = 100;            
            string input = "35";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            double ExpectedResult = backpack.LemonInventory - int.Parse(input);

            //Act
            obj.Invoke("AmountOfLemons", ingredients.LemonsNeeded);
            
            //Assert
            Assert.AreEqual(ExpectedResult, backpack.LemonInventory);
        }

        [TestMethod]
        public void DoesPlayerLoseSugarFromInventory()
        {

            //Arrange
            Inventory backpack = new Inventory();
            Recipe ingredients = new Recipe();
            PrivateObject obj = new PrivateObject(backpack);
            backpack.SugarInventory = 100;
            string input = "73";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            double ExpectedResult = backpack.SugarInventory - int.Parse(input);

            //Act
            obj.Invoke("AmountOfSugar", ingredients.SugarNeeded);

            //Assert
            Assert.AreEqual(ExpectedResult, backpack.SugarInventory);
        }

        [TestMethod]
        public void DoesPlayerLoseIceFromInventory()
        {

            //Arrange
            Inventory backpack = new Inventory();
            Recipe ingredients = new Recipe();
            PrivateObject obj = new PrivateObject(backpack);
            backpack.IceInventory = 100;
            string input = "65";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            double ExpectedResult = backpack.IceInventory - int.Parse(input);

            //Act
            obj.Invoke("AmountOfIce", ingredients.IceNeeded);

            //Assert
            Assert.AreEqual(ExpectedResult, backpack.IceInventory);
        }

        [TestMethod]
        public void DoesPlayerLoseCupsFromInventory()
        {

            //Arrange
            Inventory backpack = new Inventory();
            PrivateObject obj = new PrivateObject(backpack);
            backpack.CupInventory = 100;
            string input = "25";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            double ExpectedResult = backpack.CupInventory - int.Parse(input);

            //Act
            obj.Invoke("AmountOfCups");

            //Assert
            Assert.AreEqual(ExpectedResult, backpack.CupInventory);
        }

        [TestMethod]
        public void AreANumberOfCustomersCreated()
        {
            //Arrange
            Customers people = new Customers();
            PrivateObject obj = new PrivateObject(people);
            int Minimum = -1;
            int Maximum = 11;
            int ActualResult;

            //Act
            obj.Invoke("ListOfCustomers");
            ActualResult = people.CustomerNumbers;

            //Assert
            Assert.IsTrue(ActualResult > Minimum && ActualResult < Maximum);
        }

        }
}
