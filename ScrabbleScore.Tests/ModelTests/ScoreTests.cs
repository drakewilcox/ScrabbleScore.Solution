using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
   
    [TestMethod]
    public void WordsToCharList_RetrunsFirstCharacter_Char()
    {
      Score newScore = new Score("CRAZY");

      newScore.WordToCharList();
      char result = newScore.CharacterList[0];

      Assert.AreEqual(result, 'c');
    }

    [TestMethod]
    public void LetterScore_AddsToWordScore_Int()
    {
      Score newScore = new Score("Kazzoo");

      newScore.WordToCharList();
      newScore.LetterScore();
      int result = newScore.WordScore;

      Assert.AreEqual(result, 28);
    }
  }
}