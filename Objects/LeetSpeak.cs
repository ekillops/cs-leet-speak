using System.Collections;

namespace LeetSpeak.Objects
{
  public class LeetTranslator
  {
    public string Translate(string inputString)
    {
      string[] wordArray = inputString.Split(' ');

      for(int j = 0; j<wordArray.Length; j++)
      {
        char[] inputArray = wordArray[j].ToCharArray();

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
              if (i == 0)
              {
                inputArray[i] = '5';
              }
              else
              {
                inputArray[i] = 'z';
              }
              break;
              case 'S':
              inputArray[i] = '5';
              break;
              default:
              break;
            }
          }
          wordArray[j] = string.Join("", inputArray);
        }
      string outputString = string.Join(" ", wordArray);
      return outputString;
    }
  }
}
