using System.Drawing;

namespace Comentsys.Assets.Games.Tests;

[TestClass]
public sealed class PlayingCardTests
{
    /// <summary>
    /// Output
    /// </summary>
    /// <param name="style">Display Type</param>
    /// <param name="output">Display Output</param>
    private static void Output(string style, PlayingCardType type, string? output)
    {
        Directory.CreateDirectory($@"C:\Test\Card\{style}");
        File.WriteAllText($@"C:\Test\Card\{style}\{type}.svg", output);
    }

    [TestMethod]
    public void PlayingCard_Normal_Test()
    {
        foreach (PlayingCardType type in Enum.GetValues<PlayingCardType>())
        {
            var output = PlayingCard.Get(type).ToSvgString();
            Output($"{nameof(PlayingCard)}_Normal", type, output);
        }
    }

    [TestMethod]
    public void PlayingCard_Inverted_Test()
    {
        foreach (PlayingCardType type in Enum.GetValues<PlayingCardType>())
        {            
            var output = PlayingCard.Get(type, [Color.White, Color.Black], [Color.FromArgb(1,1,1), Color.WhiteSmoke]).ToSvgString();
            Output($"{nameof(PlayingCard)}_Inverted", type, output);
        }
    }
}
