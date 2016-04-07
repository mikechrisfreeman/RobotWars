using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Core.Location;
using RobotWars.Core.Arena;
using RobotWars.Core;

namespace RobotWars.Test.ArenaTests
{
    [TestClass]
    public class ArenaTests
    {
        [TestMethod]
        public void Arena_ValidateLocation_True()
        {
            //arrange
            IArena arena = new Arena(5, 5);
            ILocation location = new Location(1, 1, Heading.E);
            //action
            bool ok = arena.ValidateLocation(location);
            //assert
            Assert.AreEqual(true, ok);
        }

        [TestMethod]
        public void Arena_ValidateLocation_False()
        {
            //arrange
            IArena arena = new Arena(5, 5);
            ILocation location = new Location(5, 1, Heading.E);
            //action
            bool ok = arena.ValidateLocation(location);
            //assert
            Assert.AreEqual(false, ok);
        }

        [TestMethod]
        [ExpectedException(typeof(ArenaException))]
        public void Arena_ExpectException()
        {
            //arrange
            IArena arena = new Arena(-1, 5);
            ILocation location = new Location(1, 1, Heading.E);
            //action
            //assert
        }
    }
}
