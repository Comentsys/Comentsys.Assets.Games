using Newtonsoft.Json.Linq;
using System.Drawing;

namespace Comentsys.Assets.Games.Tests;

[TestClass]
public sealed class DiceFaceTests
{
    /// <summary>
    /// Values
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<object[]> Values() =>
        Enum.GetValues<DiceFaceValue>().Select(value => new object[] { value });

    /// <summary>
    /// Multiple
    /// </summary>
    public static readonly Color[] Multiple =
    [
        Color.Red,
        Color.Orange,
        Color.Yellow,
        Color.Green,
        Color.Blue,
        Color.Indigo,
        Color.Violet,
    ];

    /// <summary>
    /// Output
    /// </summary>
    /// <param name="style">Display Type</param>
    /// <param name="output">Display Output</param>
    private static void Output(string style, DiceFaceValue value, string? output)
    { 
        Directory.CreateDirectory($@"C:\Test\\Dice\{style}");
        File.WriteAllText($@"C:\Test\Dice\{style}\{value}.svg", output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void DiceFace_Single_Rounded_Test(DiceFaceValue value)
    {
        var output = DiceFace.Get(value, Color.Blue, Color.Yellow, Color.Green).ToSvgString();
        Output($"{nameof(DiceFace)}_Single_Rounded", value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void DiceFace_Multiple_Rounded_Test(DiceFaceValue value)
    {
        var output = DiceFace.Get(value, Color.Black, Color.Gray, Multiple).ToSvgString();
        Output($"{nameof(DiceFace)}_Multiple_Rounded", value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void DiceFace_Single_Square_Test(DiceFaceValue value)
    {
        var output = DiceFace.Get(value, Color.Blue, Color.Yellow, Color.Green, DiceFaceStyle.Square).ToSvgString();
        Output($"{nameof(DiceFace)}_Single_Square", value, output);
    }

    [DataTestMethod]
    [DynamicData(nameof(Values), DynamicDataSourceType.Method)]
    public void DiceFace_Multiple_Square_Test(DiceFaceValue value)
    {
        var output = DiceFace.Get(value, Color.Black, Color.Gray, Multiple, DiceFaceStyle.Square).ToSvgString();
        Output($"{nameof(DiceFace)}_Multiple_Square", value, output);
    }
}
