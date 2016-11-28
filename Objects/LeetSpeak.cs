using System.Collections;

namespace LeetSpeak.Objects
{
  public class LeetTranslator
  {
    public string Translate(string inputString)
    {
      char[] inputArray = inputString.ToCharArray();

      for(int i = 0; i<inputArray.Length; i++)
      {

        switch (inputArray[i])
        {
          case 'e':
          case 'E':
              inputArray[i] = '3';
              break;
          case 'o':
          case 'O':
              inputArray[i] = '0';
              break;
          case 'a':
          case 'A':
              inputArray[i] = '4';
              break;
          case 'i':
          case 'I':
              inputArray[i] = '1';
              break;
          case 't':
          case 'T':
              inputArray[i] = '7';
              break;
          case 's':
              inputArray[i] = 'z';
              break;
          case 'S':
              inputArray[i] = '5';
              break;
          default:
              break;
        }
      }

      string outputString = string.Join("", inputArray);
      return outputString;
    }
  }
}
