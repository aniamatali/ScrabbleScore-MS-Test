using System.Collections.Generic;
using System;

namespace Scrabble.Models
{
  public class Scrabbler
  {
    private string _inputWord;
    public int scrabbleScore = 0;
    Dictionary<char,int> myDictionary = new Dictionary<char,int>(){
      {'a',1},{'b',3},{'c',3},{'d',2},{'e',1},{'f',4},{'g',2},{'h',4},{'i',1},{'j',8},{'k',5},{'l',1},
      {'m',3},{'n',1},{'o',1},{'p',3},{'q',10},{'r',1},{'s',1},{'t',1},{'u',1},{'v',4},{'w',4},{'x',8},
      {'y',4},{'z',10} };


    public Scrabbler(string inputWord)
    {
      _inputWord = inputWord.ToLower();
    }

    public string GetWord()
    {
      return _inputWord;
    }

    public int dictScore()
    {
      char[] splitString = _inputWord.ToCharArray();
      for(var i = 0;i < splitString.Length; i++ )
      {
        scrabbleScore += myDictionary[splitString[i]];
      }
      return scrabbleScore;
    }
    public int CalculateScore()
    {
      char[] splitString = _inputWord.ToCharArray();
      for (var i=0; i < splitString.Length; i++ )

        if ((splitString[i] == 'a') || (splitString[i] == 'e') || (splitString[i] == 'i') || (splitString[i] == 'o') || (splitString[i] == 'u') || (splitString[i] == 'l') || (splitString[i] == 'n') || (splitString[i] == 'r') || (splitString[i] == 's') || (splitString[i] == 't'))
        {
          scrabbleScore+=1;
        }
        else if ((splitString[i] == 'd') || (splitString[i] == 'g'))
        {
          scrabbleScore+=2;
        }
        else if ((splitString[i] == 'b') || (splitString[i] == 'c') || (splitString[i] == 'm')|| (splitString[i] == 'p'))
        {
          scrabbleScore+=3;
        }
        else if ((splitString[i] == 'f') || (splitString[i] == 'h') || (splitString[i] == 'v')|| (splitString[i] == 'w')|| (splitString[i] == 'y'))
        {
          scrabbleScore+=4;
        }
        else if ((splitString[i] == 'k'))
        {
          scrabbleScore+=5;
        }
        else if ((splitString[i] == 'j') || (splitString[i] == 'x'))
        {
          scrabbleScore+=8;
        }
        else if ((splitString[i] == 'q') || (splitString[i] == 'z'))
        {
          scrabbleScore+=10;
        }
        else
        {
          scrabbleScore+=0;
        }
        return scrabbleScore;
      }
    }
  }
