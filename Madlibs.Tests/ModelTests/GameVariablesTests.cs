using Microsoft.VisualStudio.TestTools.UnitTesting;
using MadLibs.Models;
using System;

namespace MadLibs.Tests
{
  [TestClass]
  public class GameVariablesTests
  {
    [TestMethod]
    public void GameVariablesConstructor_CreatesInstanceOfGameVariables_GameVariables()
    {
      GameVariables newGame = new GameVariables();
      Assert.AreEqual(typeof(GameVariables), newGame.GetType());
    }

    [TestMethod]
    public void GetFirstName_GetsValueOfFirstName_String()
    {
      GameVariables newGame = new GameVariables();
      string firstName = newGame.FirstName;
      Assert.AreEqual(firstName, newGame.FirstName);
    }

    [TestMethod]
    public void SetFirstName_SetsValueOfFirstName_String()
    {
      GameVariables newGame = new GameVariables();
      string newValue = "John";
      newGame.FirstName = newValue;
      Assert.AreEqual(newValue, newGame.FirstName);
    }

    [TestMethod]
    public void GetSecondName_GetsValueOfSecondName_String()
    {
      GameVariables newGame = new GameVariables();
      string secondName = newGame.SecondName;
      Assert.AreEqual(secondName, newGame.SecondName);
    }
  }
}