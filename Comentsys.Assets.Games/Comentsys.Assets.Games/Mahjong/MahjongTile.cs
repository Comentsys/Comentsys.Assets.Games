namespace Comentsys.Assets.Games;

/// <summary>
/// Mahjong Tiles Designed by Shizhao - Licence: Public Domain - https://commons.wikimedia.org/wiki/User:Shizhao/Mahjong
/// </summary>
public class MahjongTile : AssetBase<MahjongTile>
{
    private const int width = 74;
    private const int height = 95;
    private const string folder = "Mahjong";
    private const string root = "Comentsys.Assets.Games.Resources";

    /// <summary>
    /// Get Mahjong Tile Type
    /// </summary>
    /// <param name="value">Value</param>
    /// <returns>Mahjong Tile Type</returns>
    private static MahjongTileType GetMahjongTypeValue(int value) =>
        Enum.IsDefined(typeof(MahjongTileType), value) ? (MahjongTileType)value : MahjongTileType.Back;

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="type">Mahjong Tile Type</param>
    /// <returns></returns>
    private static string Path(MahjongTileType type) =>
        $"{folder}.{Enum.GetName(typeof(MahjongTileType), type) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Mahjong Tile Type</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(MahjongTileType type) =>
        new(AsStream(root, Path(type)) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Mahjong Tile Type</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(MahjongTileType type, Color? source, Color? target) =>
        new(AsStream(root, Path(type), source, target) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Mahjong Tile Type</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(MahjongTileType type, Color[]? sources, Color[]? targets) =>
        new(AsStream(root, Path(type), sources, targets) ?? new MemoryStream(), height, width);


    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Mahjong Tile Type Value</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value) =>
        Get(GetMahjongTypeValue(value));

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Mahjong Tile Type Value</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color? source, Color? target) =>
        Get(GetMahjongTypeValue(value), source, target);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Mahjong Tile Type Value</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color[]? sources, Color[]? targets) =>
        Get(GetMahjongTypeValue(value), sources, targets);
}
