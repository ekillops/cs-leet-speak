using System.Collections;

namespace LeetSpeak
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
          default:
              break;
        }
      }

      string outputString = string.Join("", inputArray);
      return outputString;
    }
  }
}
