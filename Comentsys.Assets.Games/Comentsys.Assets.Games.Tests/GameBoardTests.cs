using System.Drawing;

namespace Comentsys.Assets.Games.Tests;

[TestClass]
public sealed class GameBoardTests
{
    /// <summary>
    /// Types
    /// </summary>
    public static IEnumerable<object[]> Types() =>
        Enum.GetValues<GameBoardType>().Select(value => new object[] { value });


    /// <summary>
    /// Colours
    /// </summary>
    public static readonly Color[] Colours =
    [
        Color.Red,
        Color.Orange,
        Color.Yellow,
        Color.Green,
        Color.Blue,
        Color.Indigo,
        Color.Violet,
        Color.Pink,
        Color.Turquoise,
        Color.Brown,
        Color.Gray,
        Color.Black,
        Color.WhiteSmoke,
        Color.Cyan,
        Color.Magenta,
        Color.Lime,
        Color.Maroon,
        Color.Navy,
        Color.Olive,
        Color.Teal
    ];

    /// <summary>
    /// Output
    /// </summary>
    /// <param name="type">Display Set</param>
    /// <param name="test">Display Test</param>
    /// <param name="output">Display Output</param>
    private static void Output(GameBoardType type, string test, string? output)
    {
        Directory.CreateDirectory($@"C:\Test\Board\{test}");
        File.WriteAllText($@"C:\Test\Board\{test}\{type}.svg", output);
    }

    [TestMethod]
    public void Board_Design_Chess_Test()
    {
        var output = GameBoard.Get(design: GameBoardDesign.Chess, showLabels: true).ToSvgString();
        Output(GameBoardType.EightByEight, $"{nameof(GameBoardDesign)}_{GameBoardDesign.Chess}", output);
    }

    [TestMethod]
    public void Board_Design_Draughts_Test()
    {
        var output = GameBoard.Get(design: GameBoardDesign.Draughts, showLabels: true).ToSvgString();
        Output(GameBoardType.EightByEight, $"{nameof(GameBoardDesign)}_{GameBoardDesign.Draughts}", output);
    }

    [TestMethod]
    public void Board_Design_Reversi_Test()
    {
        var output = GameBoard.Get(design: GameBoardDesign.Reversi, showLabels: true).ToSvgString();
        Output(GameBoardType.EightByEight, $"{nameof(GameBoardDesign)}_{GameBoardDesign.Reversi}", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Board_Type_Label_Test(GameBoardType type)
    {
        var output = GameBoard.Get(type: type, showLabels: true, foreground: Color.Red).ToSvgString();
        Output(type, "Label", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Board_Type_Single_Colour_Test(GameBoardType type)
    {
        var output = GameBoard.Get(type: type, primary: Color.CornflowerBlue, secondary: Color.DarkBlue, stroke: Color.Blue, showLabels: true).ToSvgString();
        Output(type, "Colour", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Board_Type_Multiple_Colours_Test(GameBoardType type)
    {
        var output = GameBoard.Get(type: type, fill: Colours, stroke: Color.Blue, showLabels: true).ToSvgString();
        Output(type, "Multiple", output);
    }
}
