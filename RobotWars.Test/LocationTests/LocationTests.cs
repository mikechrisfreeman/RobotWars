using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Core.Location;
using RobotWars.Core;

namespace RobotWars.Test.LocationTests
{
    [TestClass]
    public class LocationTests
    {
        [TestMethod]
        public void Location_Instantiation()
        {
            //arrange
            ILocation location = new Location(1, 1, Heading.E);
            //assert
            Assert.AreEqual(location.X, 1);
            Assert.AreEqual(location.Y, 1);
            Assert.AreEqual(location.Heading, Heading.E);
        }
        [TestMethod]
        public void Location_MakeMove_L()
        {
            //arrange
            ILocation location = new Location(1, 1, Heading.E);
            Move move = Move.L;
            //action
            var newLocation = location.MakeMove(move);
            //assert
            Assert.AreEqual(newLocation.X, 1);
            Assert.AreEqual(newLocation.Y, 1);
            Assert.AreEqual(newLocation.Heading, Heading.N);
        }
        [TestMethod]
        public void Location_MakeMove_R()
        {
            //arrange
            ILocation location = new Location(1, 1, Heading.E);
            Move move = Move.R;
            //action
            var newLocation = location.MakeMove(move);
            //assert
            Assert.AreEqual(newLocation.X, 1);
            Assert.AreEqual(newLocation.Y, 1);
            Assert.AreEqual(newLocation.Heading, Heading.S);
        }
        [TestMethod]
        public void Location_MakeMove_M()
        {
            //arrange
            ILocation location = new Location(1, 1, Heading.E);
            Move move = Move.M;
            //action
            var newLocation = location.MakeMove(move);
            //assert
            Assert.AreEqual(newLocation.X, 2);
            Assert.AreEqual(newLocation.Y, 1);
            Assert.AreEqual(newLocation.Heading, Heading.E);
        }
    }
}
