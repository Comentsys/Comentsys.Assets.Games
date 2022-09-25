namespace Comentsys.Assets.Games;

/// <summary>
/// Chess Pieces designed by Cburnett – License: CC BY-SA 3.0
/// </summary>
public class ChessPiece : AssetBase<ChessPiece>
{
    private const int width = 45;
    private const int height = 45;
    private const string folder = "Chess";
    private const string root = "Comentsys.Assets.Games.Resources";
    private static readonly Color source_black = Color.FromArgb(255, 0, 0, 0);
    private static readonly Color source_white = Color.FromArgb(255, 255, 255, 255);

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="set">Chess Piece Set</param>
    /// <param name="type">Chess Piece Type</param>
    /// <returns>Chess Piece Path</returns>
    private static string Path(ChessPieceSet set, ChessPieceType type) =>
        $"{folder}.{Enum.GetName(typeof(ChessPieceSet), set) ?? string.Empty}.{Enum.GetName(typeof(ChessPieceType), type) ?? string.Empty}";

    /// <summary>
    /// As Stream
    /// </summary>
    /// <param name="set">Chess Piece Set</param>
    /// <param name="type">Chess Piece Type</param>
    /// <param name="black">Black</param>
    /// <param name="white">White</param>
    /// <returns>Stream</returns>
    private static Stream? AsStream(ChessPieceSet set, ChessPieceType type, Color? black, Color? white)
    {
        if (black == null && white == null)
            return AsStream(root, Path(set, type));
        List<(Color source, Color target)> targetColors = new();
        if (black != null)
            targetColors.Add((source_black, black.Value));
        if (white != null)
            targetColors.Add((source_white, white.Value));
        var source = targetColors.Any() ? targetColors.Select(s => s.source).ToArray() : null;
        var target = targetColors.Any() ? targetColors.Select(s => s.target).ToArray() : null;
        return AsStream(root, Path(set, type), source, target);
    }

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="set">Chess Piece Set</param>
    /// <param name="type">Chess Piece Type</param>
    /// <param name="black">Replacement Black Colour</param>
    /// <param name="white">Replacement White Colour</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(ChessPieceSet set, ChessPieceType type, Color? black = null, Color? white = null) =>
        new(AsStream(set, type, black, white) ?? new MemoryStream(), height, width);
}
