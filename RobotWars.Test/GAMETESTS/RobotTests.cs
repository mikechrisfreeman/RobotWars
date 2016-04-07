using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Core.Location;
using RobotWars.Core.Arena;
using RobotWars.Core.Robot;
using RobotWars.Core;
using System.Collections.Generic;

namespace RobotWars.Test.GAMETESTS
{
    [TestClass]
    public class RobotTests
    {
        private IArena Arena;

        [TestInitialize]
        public void Init()
        {
            Arena = new Arena(5, 5);
        }

        [TestMethod]
        public void Robot_Scenario1()
        {
            //Arrange
            List<Move> moves = GetMoves("MLMRMMMRMMRR");
            ILocation location = new Location(0, 2, Heading.E);
            IRobot robot = new Robot(location, Arena);
            
            //Action
            foreach(var move in moves)
            {
                robot.Move(move);
                Console.WriteLine(robot.Location);
            }
            //Assert
            Assert.AreEqual(robot.Location.X, 4);
            Assert.AreEqual(robot.Location.Y, 1);
            Assert.AreEqual(robot.Location.Heading, Heading.N);
            Assert.AreEqual(robot.Penalties, 0);
        }

        [TestMethod]
        public void Robot_Scenario2()
        {
            //Arrange
            List<Move> moves = GetMoves("LMLLMMLMMMRMM");
            ILocation location = new Location(4, 4, Heading.S);
            IRobot robot = new Robot(location, Arena);

            //Action
            foreach (var move in moves)
            {
                robot.Move(move);
                Console.WriteLine(robot.Location);
            }
            //Assert
            Assert.AreEqual(robot.Location.X, 0);
            Assert.AreEqual(robot.Location.Y, 1);
            Assert.AreEqual(robot.Location.Heading, Heading.W);
            Assert.AreEqual(robot.Penalties, 1);
        }

        [TestMethod]
        public void Robot_Scenario3()
        {
            //Arrange
            List<Move> moves = GetMoves("MLMLMLM RMRMRMRM");
            ILocation location = new Location(2, 2, Heading.W);
            IRobot robot = new Robot(location, Arena);

            //Action
            foreach (var move in moves)
            {
                robot.Move(move);
                Console.WriteLine(robot.Location);
            }
            //Assert
            Assert.AreEqual(robot.Location.X, 2);
            Assert.AreEqual(robot.Location.Y, 2);
            Assert.AreEqual(robot.Location.Heading, Heading.N);
            Assert.AreEqual(robot.Penalties, 0);
        }

        [TestMethod]
        public void Robot_Scenario4()
        {
            //Arrange
            List<Move> moves = GetMoves("MMLMMLMMMMM");
            ILocation location = new Location(1, 3, Heading.N);
            IRobot robot = new Robot(location, Arena);

            //Action
            foreach (var move in moves)
            {
                robot.Move(move);
                Console.WriteLine(robot.Location);
            }
            //Assert
            Assert.AreEqual(robot.Location.X, 0);
            Assert.AreEqual(robot.Location.Y, 0);
            Assert.AreEqual(robot.Location.Heading, Heading.S);
            Assert.AreEqual(robot.Penalties, 3);
        }

        private List<Move> GetMoves(string moves)
        {
            List<Move> returnMoves = new List<Move>();
            foreach(char c in moves)
            {
                if (c == (char)Move.L)
                    returnMoves.Add(Move.L);
                else if (c == (char)Move.R)
                    returnMoves.Add(Move.R);
                else if (c == (char)Move.M)
                    returnMoves.Add(Move.M);
                else
                    Console.WriteLine("invalid Character");
            }
            return returnMoves;
        }
    }
}
