namespace Comentsys.Assets.Games;

/// <summary>
/// Game Board design by Comentsys - Licence: MIT License
/// </summary>
public class GameBoard : AssetBase<GameBoard>
{
    private const string none = "none";
    private const string asset = "Board";    
    private const string rect_id = "r{0}-c{1}";
    private const string text_id = "t-r{0}-c{1}";
    private const string root = "Comentsys.Assets.Games.Resources";

    private static readonly Color boardPrimary = Color.White;
    private static readonly Color boardSecondary = Color.Black;
    private static readonly Color boardStroke = Color.LightGray;

    private static readonly int[] sizes = [52, 102, 152, 202, 252, 302, 352, 402, 452, 502];
    private static readonly Dictionary<GameBoardDesign, (GameBoardType type, Color? primary, Color? secondary, 
        Color? stroke, Color? foreground, string[] labels)> designs = new()
    {
        {
            GameBoardDesign.Chess, 
            (
                type: GameBoardType.EightByEight,
                primary: Color.FromArgb(255, 206, 158), // Pale Orange
                secondary: Color.FromArgb(209, 139, 71), // Light Brown
                stroke: null,
                foreground: null,
                labels: [
                    "A8", "B8", "C8", "D8", "E8", "F8", "G8", "H8",  
                    "A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7",  
                    "A6", "B6", "C6", "D6", "E6", "F6", "G6", "H6",  
                    "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5",  
                    "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4",  
                    "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3",  
                    "A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2",  
                    "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1"  
                ])
        },
        {
            GameBoardDesign.Draughts,
            (
                type: GameBoardType.EightByEight,
                primary: Color.FromArgb(153, 0, 51), // Crimson Red
                secondary: Color.FromArgb(2, 1, 8), // Near Black            
                stroke: Color.FromArgb(204, 153, 51), // Warm Amber 
                foreground: Color.FromArgb(204, 153, 51), // Warm Amber
                labels: [
                    string.Empty, "1", string.Empty, "2", string.Empty, "3", string.Empty, "4",
                    "5", string.Empty, "6", string.Empty, "7", string.Empty, "8", string.Empty, 
                    string.Empty, "9", string.Empty, "10", string.Empty, "11", string.Empty, "12", 
                    "13", string.Empty, "14", string.Empty, "15", string.Empty, "16", string.Empty, 
                    string.Empty, "17", string.Empty, "18", string.Empty, "19", string.Empty, "20",
                    "21", string.Empty, "22", string.Empty, "23", string.Empty, "24", string.Empty,
                    string.Empty, "25", string.Empty, "26", string.Empty, "27", string.Empty, "28", 
                    "29", string.Empty, "30", string.Empty, "31", string.Empty, "32", string.Empty
                ])
        },
        {
            GameBoardDesign.Reversi,
            (
                type: GameBoardType.EightByEight,
                primary: Color.FromArgb(34, 139, 34), // Forest Green
                secondary: null,
                stroke: Color.FromArgb(2, 1, 8), // Near Black
                foreground: Color.FromArgb(2, 1, 8), // Near Black,
                labels: [
                    "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1",
                    "A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2",
                    "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3",
                    "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4",
                    "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5",
                    "A6", "B6", "C6", "D6", "E6", "F6", "G6", "H6",
                    "A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7",
                    "A8", "B8", "C8", "D8", "E8", "F8", "G8", "H8"
                ]
            )
        }
    };

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="type">Type</param>
    /// <returns>Asset Path</returns>
    private static string Path(GameBoardType? type) =>
        $"{asset}.{Enum.GetName(typeof(GameBoardType), type) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource String
    /// </summary>
    /// <param name="size">Size</param>
    /// <param name="type">Gameboard Type</param>
    /// <param name="design">Gameboard Design</param>
    /// <param name="primary">Primary Colour</param>
    /// <param name="secondary">Secondary Colour</param>
    /// <param name="fill">Fill Colours</param>
    /// <param name="stroke">Stroke Colour</param>
    /// <param name="foreground">Foreground Colour</param>
    /// <param name="labels">Labels</param>
    /// <param name="showLabels">Show Labels</param>
    /// <returns>Asset Resource</returns>
    private static string GetAssetResourceString(out int size, GameBoardType? type = null, GameBoardDesign ? design = null, 
        Color? primary = null, Color? secondary = null, Color[]? fill = null, Color? stroke = null, Color? foreground = null, 
        string[]? labels = null, bool showLabels = false)
    {
        var index = 0;
        var boardType = design != null ? designs[design.Value].type : type ?? GameBoardType.EightByEight;
        var boardRowsAndCols = (int)boardType;
        var boardLabels = design != null ? designs[design.Value].labels : labels;
        size = sizes[boardRowsAndCols - 1];
        var rows = boardRowsAndCols;
        var cols = boardRowsAndCols;
        var path = Path(boardType);
        var content = AsString(root, path);
        var svg = Helpers.GetSvgDocument(content, out XmlNamespaceManager manager);        
        if (design != null)
        {
            primary ??= designs[design.Value].primary;
            secondary ??= designs[design.Value].secondary;
            stroke ??= designs[design.Value].stroke;    
            foreground ??= designs[design.Value].foreground;
        }
        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                var isPrimary = (row + col) % 2 == 0;
                var rect = string.Format(rect_id, row + 1, col + 1);
                var rectNode = Helpers.GetSvgFillNode(svg, rect, manager);
                if (fill != null && index < fill.Length && fill[index] != null)
                {
                    rectNode.Value = isPrimary
                        ? AsString(rectNode.Value, boardPrimary, fill[index])
                        : AsString(rectNode.Value, boardSecondary, fill[index]);
                }
                else if (primary != null)
                {
                    rectNode.Value = isPrimary
                        ? AsString(rectNode.Value, boardPrimary, primary)
                        : AsString(rectNode.Value, boardSecondary, secondary ?? primary);
                }
                var strokeNode = Helpers.GetSvgStrokeNode(svg, rect, manager);
                strokeNode.Value = stroke != null ? AsString(strokeNode.Value, boardStroke, stroke) : none;
                var label = string.Format(text_id, row + 1, col + 1);
                var labelNode = Helpers.GetSvgFillNode(svg, label, manager);
                if (showLabels)
                {
                    labelNode.Value = isPrimary
                        ? AsString(labelNode.Value, boardSecondary, foreground ?? secondary ?? primary)
                        : AsString(labelNode.Value, boardPrimary, foreground ?? primary);
                    if (boardLabels != null)
                    {
                        Helpers.GetSvgNode(svg, label, manager).InnerText = 
                            index < boardLabels.Length ? boardLabels[index] : string.Empty;
                    }
                }
                else
                {
                    labelNode.Value = none;
                }
                index++;
            }
        }
        return svg.OuterXml;
    }

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="design">Gameboard Design</param>
    /// <param name="showLabels">Show Board Labels?</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(GameBoardDesign design, bool showLabels = false) =>
        new(FromString(GetAssetResourceString(out var size, design: design, showLabels: showLabels)) ?? new MemoryStream(), size, size);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Gameboard Type</param>
    /// <param name="foreground">Label Foreground Colour</param>
    /// <param name="labels">Board Labels</param>
    /// <param name="showLabels">Show Board Labels?</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(GameBoardType type, Color? foreground = null, string[]? labels = null, bool showLabels = false) => 
        new(FromString(GetAssetResourceString(out var size, type: type, foreground: foreground, labels: labels, showLabels: showLabels)) ?? new MemoryStream(), size, size);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Gameboard Type</param>
    /// <param name="primary">Primary Board Colour</param>
    /// <param name="secondary">Secondary Board Colour</param>
    /// <param name="stroke">Board Stroke Colour</param>
    /// <param name="foreground">Label Foreground Colour</param>
    /// <param name="labels">Board Labels</param>
    /// <param name="showLabels">Show Board Labels?</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(GameBoardType type, Color? primary, Color? secondary, Color? stroke = null, Color? foreground = null, string[]? labels = null, bool showLabels = false) =>
        new(FromString(GetAssetResourceString(out var size, type: type, primary: primary, secondary: secondary, stroke: stroke, foreground: foreground, labels: labels, showLabels: showLabels)) ?? 
            new MemoryStream(), size, size);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Gameboard Type</param>
    /// <param name="fill">Board Fill Colours</param>
    /// <param name="stroke">Board Stroke Colour</param>
    /// <param name="foreground">Label Foreground Colour</param>
    /// <param name="labels">Board Labels</param>
    /// <param name="showLabels">Show Board Labels?</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(GameBoardType type, Color[]? fill, Color? stroke = null, Color? foreground = null, string[]? labels = null, bool showLabels = false) =>
        new(FromString(GetAssetResourceString(out var size, type: type, fill: fill, stroke: stroke, foreground: foreground, labels: labels, showLabels: showLabels)) ??
            new MemoryStream(), size, size);
}
