using System.Drawing;

namespace Comentsys.Assets.Games.Tests;

[TestClass]
public sealed class DominoTests
{
    /// <summary>
    /// Values
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<object[]> Values() =>
        Enum.GetValues<DominoValue>().Select(value => new object[] { value });

    /// <summary>
    /// Multiple
    /// </summary>
    public static readonly Color[] Multiple =
    [
        Color.Red,
        Color.Orange,
        Color.Yellow,
        Color.Green,
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
    /// <param name="set">Display Set</param>
    /// <param name="style">Display Type</param>
    /// <param name="output">Display Output</param>
    private static void Output(string style, DominoSet set, DominoValue value, string? output)
    {
        Directory.CreateDirectory($@"C:\Test\\Domino\{set}\{style}");
        File.WriteAllText($@"C:\Test\Domino\{set}\{style}\{value}.svg", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Single_Vertical_Rounded_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Color.Green, DominoSet.Vertical, DominoStyle.Rounded).ToSvgString();
        Output($"{nameof(Domino)}_Single_Rounded", DominoSet.Vertical, value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Single_Vertical_Square_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Color.Green, DominoSet.Vertical, DominoStyle.Square).ToSvgString();
        Output($"{nameof(Domino)}_Single_Square", DominoSet.Vertical, value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Single_Horizontal_Rounded_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Color.Green, DominoSet.Horizontal, DominoStyle.Rounded).ToSvgString();
        Output($"{nameof(Domino)}_Single_Rounded", DominoSet.Horizontal, value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Single_Horizontal_Square_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Color.Green, DominoSet.Horizontal, DominoStyle.Square).ToSvgString();
        Output($"{nameof(Domino)}_Single_Square", DominoSet.Horizontal, value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Multiple_Vertical_Rounded_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Multiple, DominoSet.Vertical, DominoStyle.Rounded).ToSvgString();
        Output($"{nameof(Domino)}_Multiple_Rounded", DominoSet.Vertical, value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Multiple_Vertical_Square_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Multiple, DominoSet.Vertical, DominoStyle.Square).ToSvgString();
        Output($"{nameof(Domino)}_Multiple_Square", DominoSet.Vertical, value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Multiple_Horizontal_Rounded_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Multiple, DominoSet.Horizontal, DominoStyle.Rounded).ToSvgString();
        Output($"{nameof(Domino)}_Multiple_Rounded", DominoSet.Horizontal, value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void Domino_Multiple_Horizontal_Square_Test(DominoValue value)
    {
        var output = Domino.Get(value, Color.Blue, Color.Yellow, Multiple, DominoSet.Horizontal, DominoStyle.Square).ToSvgString();
        Output($"{nameof(Domino)}_Multiple_Square", DominoSet.Horizontal, value, output);
    }
}
