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

    public void GetFirstName_GetsValueOfFirstName_String()
    {
      GameVariables newGame = new GameVariables();
      string firstName = newGame.FirstName;
      Assert.AreEqual(firstName, newGame.FirstName);
    }
  }
}