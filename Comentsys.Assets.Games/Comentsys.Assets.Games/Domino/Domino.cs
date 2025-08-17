namespace Comentsys.Assets.Games;

/// <summary>
/// Domino design by Comentsys - Licence: MIT License
/// </summary>
public class Domino : AssetBase<Domino>
{
    private const int rows = 3;
    private const int cols = 3;
    private const int total = 13;
    private const int halves = 2;
    private const int width = 100;
    private const int height = 200;
    private const char comma = ',';
    private const string back = "back";
    private const string none = "none";    
    private const string asset = "Domino";
    private const string divider = "divider";
    private const string format = "h{0}-r{1}-c{2}";
    private const string root = "Comentsys.Assets.Games.Resources";
    private static readonly Color foreground = Color.FromArgb(255, 0, 0, 0); // Black
    private static readonly Color background = Color.FromArgb(255, 255, 255, 255); // White    
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

    private static readonly string[] tiles = 
    { 
        string.Empty, 
        "0,0", "0,1", "0,2", "0,3", "0,4", "0,5", "0,6", 
        "1,1", "1,2", "1,3", "1,4", "1,5", "1,6", 
        "2,2", "2,3", "2,4", "2,5", "2,6", 
        "3,3", "3,4", "3,5", "3,6", 
        "4,4", "4,5", "4,6", 
        "5,5", "5,6", 
        "6,6" 
    };

    /// <summary>
    /// Get Value
    /// </summary>
    /// <param name="value">Value</param>
    /// <returns>Domino Value</returns>
    private static DominoValue GetValue(int value) =>
        Enum.IsDefined(typeof(DominoValue), value) ? (DominoValue)value : DominoValue.Back;

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="set">Set</param>
    /// <param name="style">Style</param>
    /// <returns>Asset Path</returns>
    private static string Path(DominoSet? set, DominoStyle? style) =>
        $"{asset}.{Enum.GetName(typeof(DominoSet), set) ?? string.Empty}.{Enum.GetName(typeof(DominoStyle), style) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource String
    /// </summary>
    /// <param name="value">Domino Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pip">Pip Colour</param>
    /// <param name="pips">Pip Colours</param>
    /// <param name="set">Domino Set</param>
    /// <param name="style">Domino Style</param>
    /// <returns>Asset Resource String</returns>
    private static string GetAssetResourceString(DominoValue value, Color? fill, Color? stroke, Color? pip = null, Color[]? pips = null, 
       DominoSet? set = DominoSet.Vertical, DominoStyle? style = DominoStyle.Rounded)
    {
        var index = 0;
        var count = 0;
        var section = 0;
        var content = AsString(root, Path(set, style));
        var svg = Helpers.GetSvgDocument(content, out XmlNamespaceManager manager);
        if (fill != null)
        {
            var node = Helpers.GetSvgFillNode(svg, back, manager);
            node.Value = AsString(node.Value, background, fill);
        }
        if(stroke != null)
        {
            var node = Helpers.GetSvgStrokeNode(svg, back, manager);
            node.Value = AsString(node.Value, foreground, stroke);
        }
        var colours = pips != null ? Helpers.Pad(pips, foreground, total) : null;
        for (var half = 0; half < halves; half++)
        {
            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    bool show;
                    var id = string.Format(format, half + 1, row + 1, col + 1);
                    var node = Helpers.GetSvgFillNode(svg, id, manager);
                    var tile = tiles[(int)value];
                    var div = Helpers.GetSvgFillNode(svg, divider, manager);
                    if (tile.Contains(comma))
                    {
                        string[] pair = tiles[(int)value].Split(comma);
                        var face = layout[int.Parse(pair[half])];
                        show = face[section] == 1;
                        div.Value = AsString(div.Value, foreground, colours != null ? colours.Last() : pip);
                        section++;
                    }
                    else
                    {                        
                        div.Value = none;
                        show = false;
                    }
                    if (show)
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
            section = 0;
        }
        return svg.OuterXml;
    }

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Domino Value</param>
    /// <param name="set">Domino Set</param>
    /// <param name="style">Domino Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(DominoValue value, DominoSet? set = DominoSet.Vertical, DominoStyle? style = DominoStyle.Rounded) =>
        new(FromString(GetAssetResourceString(value, null, null, null, null, set, style)) ?? new MemoryStream(), 
                set == DominoSet.Vertical ? height : width, set == DominoSet.Vertical ? width : height);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Domino Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pip">Pip Colour</param>
    /// <param name="set">Domino Set</param>
    /// <param name="style">Domino Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(DominoValue value, Color? fill, Color? stroke, Color? pip, 
        DominoSet? set = DominoSet.Vertical, DominoStyle? style = DominoStyle.Rounded) =>
        new(FromString(GetAssetResourceString(value, fill, stroke, pip, null, set, style)) ?? new MemoryStream(),
            set == DominoSet.Vertical ? height : width, set == DominoSet.Vertical ? width : height);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Domino Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pips">Pip Colours</param>
    /// <param name="set">Domino Set</param>
    /// <param name="style">Domino Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(DominoValue value, Color? fill, Color? stroke, Color[]? pips, 
        DominoSet? set = DominoSet.Vertical, DominoStyle? style = DominoStyle.Rounded) =>
        new(FromString(GetAssetResourceString(value, fill, stroke, null, pips, set, style)) ?? new MemoryStream(),
            set == DominoSet.Vertical ? height : width, set == DominoSet.Vertical ? width : height);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Domino Value</param>
    /// <param name="set">Domino Set</param>
    /// <param name="style">Domino Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, DominoSet? set = DominoSet.Vertical, DominoStyle? style = DominoStyle.Rounded) =>
        Get(GetValue(value), set, style);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Domino Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pip">Pip Colour</param>
    /// <param name="set">Domino Set</param>
    /// <param name="style">Domino Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color? fill, Color? stroke, Color? pip, 
        DominoSet? set = DominoSet.Vertical, DominoStyle? style = DominoStyle.Rounded) =>
        Get(GetValue(value), fill, stroke, pip, set, style);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Domino Value</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="pips">Pip Colours</param>
    /// <param name="set">Domino Set</param>
    /// <param name="style">Domino Style</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color? fill, Color? stroke, Color[]? pips, 
        DominoSet? set = DominoSet.Vertical, DominoStyle? style = DominoStyle.Rounded) =>
        Get(GetValue(value), fill, stroke, pips, set, style);
}
