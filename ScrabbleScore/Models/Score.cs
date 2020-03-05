using System; 
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Score
  {
    public string InputWord { get; set; }
    public List<char> CharacterList {get; set; }
    public int WordScore { get; set; }

    public Score (string inputWord)
    {
      InputWord = inputWord; 
      CharacterList = new List<char> {};
      WordScore = 0;
    }

    public void WordToCharList()
    {
      char[] inputWordArray = InputWord.ToLower().ToCharArray();
      for (int index = 0; index < inputWordArray.Length; index ++)
      {
        CharacterList.Add(inputWordArray[index]);
      }
    }
    
    public void LetterScore()
    {
      foreach (char listChar in CharacterList)
      {
        if(listChar == 'a' || listChar == 'e' || listChar =='i' || listChar == 'o' || listChar == 'u' || listChar == 'l' || listChar == 'n' || listChar == 'r' || listChar == 's' || listChar == 't')
        {
          WordScore ++;
        }
        else if (listChar == 'd' || listChar == 'g')
        {
          WordScore += 2;
        }
        else if (listChar == 'b' || listChar == 'c' || listChar == 'm' || listChar == 'p')
        {
          WordScore += 3;
        }
        else if (listChar == 'f' || listChar == 'h' || listChar == 'v' || listChar == 'w' || listChar == 'y')
        {
          WordScore += 4;
        }
        else if (listChar == 'k')
        {
          WordScore += 5;
        }
        else if (listChar == 'j' || listChar == 'x')
        {
          WordScore += 8;
        }
        else if (listChar == 'q' || listChar == 'z')
        {
          WordScore += 10;
        }
        else {
          WordScore += 0;
        }
      }
    }
  }
}
