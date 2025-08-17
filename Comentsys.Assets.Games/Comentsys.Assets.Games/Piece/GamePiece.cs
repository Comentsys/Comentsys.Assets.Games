namespace Comentsys.Assets.Games;

/// <summary>
/// Game Piece design by Comentsys - Licence: MIT License
/// </summary>
public class GamePiece : AssetBase<GamePiece>
{
    private const int size = 100;
    private const string back = "back";
    private const string text = "text";
    private const string asset = "Piece";
    private const string root = "Comentsys.Assets.Games.Resources";

    private static readonly Color pieceFill = Color.Goldenrod;
    private static readonly Color pieceForeground = Color.Black;
    private static readonly Color pieceStroke = Color.DarkGoldenrod;

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="set">Set</param>
    /// <param name="type">Type</param>
    /// <returns>Asset Path</returns>
    private static string Path(GamePieceSet? set, GamePieceType? type) =>
        $"{asset}.{Enum.GetName(typeof(GamePieceSet), set) ?? string.Empty}.{Enum.GetName(typeof(GamePieceType), type) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource String
    /// </summary>
    /// <param name="set">Game Piece Set</param>
    /// <param name="type">Game Piece Type</param>
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="foreground">Foreground Color</param>
    /// <param name="value">Value</param> 
    /// <returns>Asset Resource String</returns>
    private static string GetAssetResourceString(GamePieceSet? set = GamePieceSet.Regular, GamePieceType? type = GamePieceType.Circle, 
        Color ? fill = null, Color? stroke = null, Color? foreground = null, string? value = null)
    {
        var content = AsString(root, Path(set, type));
        var svg = Helpers.GetSvgDocument(content, out XmlNamespaceManager manager);
        if (!string.IsNullOrWhiteSpace(value))
        {
            Helpers.GetSvgNode(svg, text, manager).InnerText = value;
        }
        if(foreground != null)
        {
            var textNode = Helpers.GetSvgFillNode(svg, text, manager);
            textNode.Value = AsString(textNode.Value, pieceForeground, foreground);
        }
        if (stroke != null)
        {
            var strokeNode = Helpers.GetSvgStrokeNode(svg, back, manager);
            strokeNode.Value = AsString(strokeNode.Value, pieceStroke, stroke);
        }
        if (fill != null)
        {
            var fillNode = Helpers.GetSvgFillNode(svg, back, manager);
            fillNode.Value = AsString(fillNode.Value, pieceFill, fill);
        }
        return svg.OuterXml;
    }

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="set">Game Piece Set</param>
    /// <param name="type">Game Piece Type</param> 
    /// <param name="fill">Fill Colour</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="foreground">Foreground Color</param>
    /// <param name="value">Value</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(GamePieceSet? set = GamePieceSet.Regular, GamePieceType? type = GamePieceType.Circle, 
        Color? fill = null, Color? stroke = null, Color? foreground = null, string? value = null) =>
        new(FromString(GetAssetResourceString(set, type, fill, stroke, foreground, value)) ??
            new MemoryStream(), size, size);
}
