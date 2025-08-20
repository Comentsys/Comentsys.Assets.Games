namespace Comentsys.Assets.Games;

/// <summary>
/// Playing Cards designed by TheRealRevK - License: CC0 1.0 Universal
/// </summary>
public class PlayingCard : AssetBase<PlayingCard>
{
    private const int width = 180;
    private const int height = 252;
    private const string folder = "PlayingCard";
    private const string root = "Comentsys.Assets.Games.Resources";

    /// <summary>
    /// Get Playing Card Type
    /// </summary>
    /// <param name="value">Value</param>
    /// <returns>Playing Card Type</returns>
    private static PlayingCardType GetPlayingCardType(int value) =>
        Enum.IsDefined(typeof(PlayingCardType), value) ? (PlayingCardType)value : PlayingCardType.Back;

    /// <summary>
    /// Path
    /// </summary>
    /// <param name="type">Playing Card Type</param>
    /// <returns></returns>
    private static string Path(PlayingCardType type) =>
        $"{folder}.{Enum.GetName(typeof(PlayingCardType), type) ?? string.Empty}";

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Playing Card Type</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(PlayingCardType type) =>
        new(AsStream(root, Path(type)) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Playing Card Type</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(PlayingCardType type, Color? source, Color? target) =>
        new(AsStream(root, Path(type), source, target) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="type">Playing Card Type</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(PlayingCardType type, Color[]? sources, Color[]? targets) =>
        new(AsStream(root, Path(type), sources, targets) ?? new MemoryStream(), height, width);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Playing Card Type Value</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value) =>
        Get(GetPlayingCardType(value));

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Playing Card Type Value</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color? source, Color? target) =>
        Get(GetPlayingCardType(value), source, target);

    /// <summary>
    /// Get Asset Resource
    /// </summary>
    /// <param name="value">Playing Card Type Value</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Asset Resource</returns>
    public static AssetResource Get(int value, Color[]? sources, Color[]? targets) =>
        Get(GetPlayingCardType(value), sources, targets);
}
