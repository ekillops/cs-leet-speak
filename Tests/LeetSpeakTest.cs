using Xunit;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void Translate_ReplaceEWith3_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "e";
      Assert.Equal("3", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_ReplaceOWith0_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "o";
      Assert.Equal("0", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_ReplaceAWith4_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "a";
      Assert.Equal("4", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_ReplaceIWith1_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "i";
      Assert.Equal("1", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_ReplaceTWith7_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "t";
      Assert.Equal("7", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_RepalceLowerSWithLowerZ_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "s";
      Assert.Equal("z", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_ReplaceUpperSWith5_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "S";
      Assert.Equal("5", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_ReplaceMultipleLetterInstances_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "Beer";
      Assert.Equal("B33r", testTranslator.Translate(input));
    }

    [Fact]
    public void Translate_ReplaceMultipleDifferentCharacters_true()
    {
      LeetTranslator testTranslator = new LeetTranslator();
      string input = "cat smiles";
      Assert.Equal("c47 zm1l3z", testTranslator.Translate(input));
    }
  }
}
