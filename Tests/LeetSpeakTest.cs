using Xunit;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void Translate_ReplaceEWith3_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "Letter";
      Assert.Equal("L3tt3r", testTranslator.Translate(input));
    }

  }
}
