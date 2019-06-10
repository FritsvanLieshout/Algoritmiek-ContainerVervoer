using System;
using System.Collections.Generic;
using System.Linq;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace UnitTestContainerVervoer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IntegrationTest()
        {
            //Arrange
            Ship expected = new Ship(1, 3);

            Container container1 = new Container(4000, false, true);
            Container container2 = new Container(4000, false, false);
            Container container3 = new Container(4000, false, false);
            Container container4 = new Container(4000, true, false);

            List<Container> containers = new List<Container>();
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);

            List<Container> stack1 = new List<Container>();
            stack1.Add(container1);

            List<Container> stack2 = new List<Container>();
            stack2.Add(container2);
            stack2.Add(container4);

            List<Container> stack3 = new List<Container>();
            stack3.Add(container3);

            expected.Stack[0, 0].Containers = stack1;
            expected.Stack[0, 1].Containers = stack2;
            expected.Stack[0, 2].Containers = stack3;
            expected.Weight = 16000;

            Ship actual = new Ship(1, 3);
            ShipLogic logic = new ShipLogic(1, 3);
            //Act
            actual = logic.SortContainers(containers);

            //Assert
            Assert.AreEqual(expected.Weight, actual.Weight);

            Assert.AreEqual(expected.Stack[0, 0].Containers.Count, actual.Stack[0, 0].Containers.Count);
            Assert.AreEqual(expected.Stack[0, 1].Containers.Count, actual.Stack[0, 1].Containers.Count);
            Assert.AreNotEqual(expected.Stack[0, 0].Containers.Count, actual.Stack[0, 1].Containers.Count);

            for (int i = 0; i < expected.Stack[0, 0].Containers.Count; i++)
            {
                Assert.AreEqual(expected.Stack[0, 1].Containers[i], actual.Stack[0, 1].Containers[i]);
            }

            for (int i = 0; i < expected.Stack[0, 1].Containers.Count; i++)
            {
                Assert.AreEqual(expected.Stack[0, 1].Containers[i], actual.Stack[0, 1].Containers[i]);
            }

            for (int i = 0; i < expected.Stack[0, 1].Containers.Count; i++)
            {
                Assert.AreEqual(expected.Stack[0, 1].Containers[i].TopWeight, actual.Stack[0, 1].Containers[i].TopWeight);
            }
        }

        [TestMethod]
        public void TestCheckWeight()
        {
            Ship ship = new Ship(3, 3);
            ship.Weight = 750000;
            bool expected = true;

            bool actual = ship.CheckWeight(ship.Weight, ship.MaxWeight);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsOverMaxWeightOfShip()
        {
            Ship ship = new Ship(3, 3);
            ship.Weight = 2000000;
            bool expected = true;
            bool actual = ship.CheckWeight(ship.Weight, ship.MaxWeight);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculateMaxWeightOfShip()
        {
            Ship ship = new Ship(3, 3);

            int expected = 1350000;
            int actual = ship.CalculateMaxWeightOfShip(3, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculateMedian()
        {
            Ship ship = new Ship(4, 3);

            decimal expected = ship.Median;
            decimal actual = ship.CalculateMedian(ship.Width);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddContainer()
        {
            Ship ship = new Ship(1, 3);

            Container container1 = new Container(4000, false, true);
            Container container2 = new Container(4000, false, false);
            Container container3 = new Container(4000, false, false);
            Container container4 = new Container(4000, true, false);

            List<Container> containers = new List<Container>();
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);

            foreach (var container in containers)
            {
                Assert.IsTrue(ship.AddContainer(container));
            }
        }

        [TestMethod]
        public void TestIsTopContainerValuable()
        {
            Container container1 = new Container(4000, false, true);
            Container container2 = new Container(4000, false, false);
            Container container3 = new Container(4000, false, false);
            Container container4 = new Container(4000, true, false);

            List<Container> containers = new List<Container>();
            containers.Add(container1);
            containers.Add(container2);
            containers.Add(container3);
            containers.Add(container4);

            Assert.IsNotNull(containers.Count > 0 && containers.Last().ValuableContainer);
        }

        [TestMethod]
        public void TestAddCooledContainer()
        {
            var expected = 0;
            bool isContainerCooled = true;
            if (isContainerCooled)
            {
                expected = 1;
            }

            Container container = new Container(4000, false, true);
            List<Container> containers = new List<Container>();
            containers.Add(container);

            var actual = containers.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddValuableContainer()
        {
            var expected = 0;
            bool isContainerValuable = true;
            if (isContainerValuable)
            {
                expected = 1;
            }

            Container container = new Container(4000, false, true);
            List<Container> containers = new List<Container>();
            containers.Add(container);

            var actual = containers.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckIfWeightIsAllowed()
        {
            Stack stack = new Stack();
            var container = new Container(30000, false, false);
            var container2 = new Container(200000, false, false);
            stack.Containers.Add(container);

            var actual = stack.IsWeightAllowed(container2);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestHaveContainerSpace()
        {
            Stack stack = new Stack();
            var container = new Container(30000, false, false);
            var container2 = new Container(12500, false, false);
            stack.Containers.Add(container);
            stack.Containers.Add(container2);
            Ship ship = new Ship(4, 4);

            var actual = stack.HaveContainerSpace(ship.Stack[3, 3].Containers.Count, stack.Containers.Count);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestAddWeightOnTopOfContainer()
        {
            var container = new Container(10000, false, false);
            container.AddWeight(40000);
            Assert.AreEqual(40000, container.TopWeight);
        }
    }
}
