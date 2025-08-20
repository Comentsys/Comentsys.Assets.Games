namespace Comentsys.Assets.Games;

/// <summary>
/// Dice Face design by Comentsys - Licence: MIT License
/// </summary>
public class DiceFace : AssetBase<DiceFace>
{
    private const int rows = 3;
    private const int cols = 3;
    private const int total = 6;
    private const int width = 100;
    private const int height = 100;
    private const string back = "back";
    private const string none = "none";
    private const string asset = "Dice";
    private const string format = "r{0}-c{1}";
    private const string root = "Comentsys.Assets.Games.Resources";
    private static readonly Color foreground = Color.FromArgb(255, 255, 255, 255); // White
    private static readonly Color background = Color.FromArgb(255, 255, 0, 0); // Red
    private static readonly byte[][] layout =
    {
        [0, 0, 0,
         0, 0, 0,
         0, 0, 0], // 0

        [0, 0, 0,
         0, 1, 0,
         0, 0, 0], // 1

        [1, 0, 0,
         0, 0, 0,
         0, 0, 1], // 2

        [1, 0, 0,
         0, 1, 0,
         0, 0, 1], // 3

        [1, 0, 1,
         0, 0, 0,
         1, 0, 1], // 4

        [1, 0, 1,
         0, 1, 0,
         1, 0, 1], // 5

        [1, 0, 1,
         1, 0, 1,
         1, 0, 1], // 6
    };

    /// <summary>
    /// Get Value
    /// </summary>
    /// <param name="value">Value</param>
    /// <returns>Dice Face Value</returns>
    private static DiceFaceValue GetValue(int value) =>
        Enum.IsDefined(typeof(DiceFaceValue), value) ? (DiceFaceValue)value : DiceFaceValue.Blank;

    /// <summary>
    /// Get Asset
    /// </summary>
    /// <param name="style">Style</param>
    /// <returns>Asset Path</returns>
    private static string GetAsset(DiceFaceStyle? style) =>
        $"{asset}.{Enum.GetName(typeof(DiceFaceStyle), style) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource String
    /// </summary>
    /// <param name="value">Dice Face Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pip">Pip Colour</param>
    /// <param name="pips">Pip Colours</param>
    /// <param name="style">Dice Face Style</param>
    /// <returns>Asset Resource String</returns>
    private static string GetAssetResourceString(DiceFaceValue value, Color? fill = null, Color? stroke = null, Color? pip = null, Color[]? pips = null, 
        DiceFaceStyle? style = DiceFaceStyle.Rounded)
    {
        var index = 0;
        var count = 0;
        var face = layout[(int)value];
        var content = AsString(root, GetAsset(style));
        var svg = Helpers.GetSvgDocument(content, out XmlNamespaceManager manager);

        if (fill != null)
        {
            var node = Helpers.GetSvgFillNode(svg, back, manager);
            node.Value = AsString(node.Value, background, fill);                   
        }
        if(stroke != null)
        {
            var node = Helpers.GetSvgStrokeNode(svg, back, manager);
            node.Value = AsString(node.Value, background, stroke);
        }

        var colours = pips != null ? Helpers.Pad(pips, foreground, total) : null;
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                var id = string.Format(format, row + 1, col + 1);
                var node = Helpers.GetSvgFillNode(svg, id, manager);
                if(face[index] == 1)
                {      
                    node.Value = AsString(node.Value, foreground, colours != null ? colours[count] : pip);
                    count++;                    
                }
                else
                {
                    node.Value = none;
                }
                index++;
            }
        }
        return svg.OuterXml;
    }

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Dice Face Value</param>
    /// <param name="style">Dice Face Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(DiceFaceValue value, 
        DiceFaceStyle? style = DiceFaceStyle.Rounded) =>
        new(FromString(GetAssetResourceString(value, null, null, null, null, style)) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Dice Face Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pip">Pip Colour</param>
    /// <param name="style">Dice Face Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(DiceFaceValue value, Color? fill, Color? stroke, Color? pip, 
        DiceFaceStyle? style = DiceFaceStyle.Rounded) =>
        new(FromString(GetAssetResourceString(value, fill, stroke, pip, null, style)) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Dice Face Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke COlour</param>
    /// <param name="pips">Pip Colours</param>
    /// <param name="style">Dice Face Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(DiceFaceValue value, Color? fill, Color? stroke, Color[]? pips, 
        DiceFaceStyle? style = DiceFaceStyle.Rounded) =>
        new(FromString(GetAssetResourceString(value, fill, stroke, null, pips, style)) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Value</param>
    /// <param name="style">Dice Face Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, DiceFaceStyle? style = DiceFaceStyle.Rounded) =>
        Get(GetValue(value), style);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pip">Pip Colour</param>
    /// <param name="style">Dice Face Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color? fill, Color? stroke, Color? pip, 
        DiceFaceStyle? style = DiceFaceStyle.Rounded) =>
        Get(GetValue(value), fill, stroke, pip, style);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pips">Pip Colours</param>
    /// <param name="style">Dice Face Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color? fill, Color? stroke, Color[]? pips, 
        DiceFaceStyle? style = DiceFaceStyle.Rounded) =>
        Get(GetValue(value), fill, stroke, pips, style);
}