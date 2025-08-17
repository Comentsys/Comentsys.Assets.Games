using System.Drawing;

namespace Comentsys.Assets.Games.Tests;

[TestClass]
public sealed class GamePieceTests
{
    /// <summary>
    /// Values
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<object[]> Types() =>
        Enum.GetValues<GamePieceType>().Select(value => new object[] { value });

    /// <summary>
    /// Output
    /// </summary>
    /// <param name="set">Display Set</param>
    /// <param name="type">Display Type</param>
    /// <param name="output">Display Output</param>
    private static void Output(GamePieceSet set, GamePieceType type, string colour, string? output)
    {
        Directory.CreateDirectory($@"C:\Test\Piece\{set}");
        File.WriteAllText($@"C:\Test\Piece\{set}\{type}_{colour}.svg", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Regular_Normal_Piece_Test(GamePieceType type)
    {
        var output = GamePiece.Get(set: GamePieceSet.Regular, type: type).ToSvgString();
        Output(GamePieceSet.Regular, type, "normal", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Medium_Normal_Piece_Test(GamePieceType type)
    {
        var output = GamePiece.Get(set: GamePieceSet.Medium, type: type).ToSvgString();
        Output(GamePieceSet.Medium, type, "normal", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Light_Normal_Piece_Test(GamePieceType type)
    {
        var output = GamePiece.Get(set: GamePieceSet.Light, type: type).ToSvgString();
        Output(GamePieceSet.Light, type, "normal", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Regular_Colour_Piece_Test(GamePieceType type)
    {
        var output = GamePiece.Get(set: GamePieceSet.Regular, type: type, value: "24", fill: Color.CornflowerBlue, stroke: Color.DarkBlue).ToSvgString();
        Output(GamePieceSet.Regular, type, "colour", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Medium_Colour_Piece_Test(GamePieceType type)
    {
        var output = GamePiece.Get(set: GamePieceSet.Medium, type: type, value: "24", fill: Color.CornflowerBlue, stroke: Color.DarkBlue).ToSvgString();
        Output(GamePieceSet.Medium, type, "colour", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Types), DynamicDataSourceType.Method)]
    public void Light_Colour_Piece_Test(GamePieceType type)
    {
        var output = GamePiece.Get(set: GamePieceSet.Light, type: type, value: "24", fill: Color.CornflowerBlue, stroke: Color.DarkBlue).ToSvgString();
        Output(GamePieceSet.Light, type, "colour", output);
    }
}
