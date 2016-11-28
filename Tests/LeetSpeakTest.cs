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
    [Fact]
    public void Translate_ReplaceOWith0_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "Word";
      Assert.Equal("W0rd", testTranslator.Translate(input));
    }
    [Fact]
    public void Translate_ReplaceAWith4_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "Cat";
      Assert.Equal("C4t", testTranslator.Translate(input));
    }
    [Fact]
    public void Translate_ReplaceIWith1_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "Input";
      Assert.Equal("1nput", testTranslator.Translate(input));
    }
  }
}
