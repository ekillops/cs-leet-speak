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
              inputArray[i] = '3';
              break;
          case 'E':
              inputArray[i] = '3';
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
