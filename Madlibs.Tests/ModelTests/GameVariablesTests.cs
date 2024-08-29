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

    [TestMethod]
    public void SetSecondName_SetsValueOfSecondName_String()
    {
      GameVariables newGame = new GameVariables();
      string newValue = "Jane";
      newGame.SecondName = newValue;
      Assert.AreEqual(newValue, newGame.SecondName);
    }

    [TestMethod]
    public void GetAnimal_GetsValueOfAnimal_String()
    {
      GameVariables newGame = new GameVariables();
      string animal = newGame.Animal;
      Assert.AreEqual(animal, newGame.Animal);
    }

    [TestMethod]
    public void SetAnimal_SetsValueOfAnimal_String()
    {
      GameVariables newGame = new GameVariables();
      string newValue = "Dog";
      newGame.Animal = newValue;
      Assert.AreEqual(newValue, newGame.Animal);
    }

    [TestMethod]
    public void GetExclamation_GetsValueOfExclamation_String()
    {
      GameVariables newGame = new GameVariables();
      string exclamation = newGame.Exclamation;
      Assert.AreEqual(exclamation, newGame.Exclamation);
    }
  }
}