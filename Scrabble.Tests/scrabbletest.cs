using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble.Models;

namespace Scrabble.Tests
{

  [TestClass]
  public class ScrabblerTests
  {
    [TestMethod]
    public void GetValue()
    {
      //Arrange
      Scrabbler newWord = new Scrabbler("ADBFJKQ");

      int output = 33;

      //Act
      int result = (newWord.dictScore());
      Console.WriteLine("result " + result);

      //Assert
      Assert.AreEqual(result, output);

    }

    //
    //   public void Dispose()
    //   {
    //     Anagramer.ClearAll();
    //   }
    }
  }
