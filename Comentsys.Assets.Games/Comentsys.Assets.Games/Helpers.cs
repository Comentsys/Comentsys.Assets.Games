namespace Comentsys.Assets.Games;

/// <summary>
/// Helpers
/// </summary>
internal static class Helpers
{
    private const string asset_svg_tag = "svg";
    private const string asset_svg_fill = "fill";
    private const string asset_svg_stroke = "stroke";
    private const string asset_svg_name_space = "http://www.w3.org/2000/svg";
    private const string asset_svg_id = "//*[@id='{0}']";
    private const string asset_svg_id_attribute = "//*[@id='{0}']/@{1}";

    /// <summary>
    /// Get SVG Document
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="manager">XML Namespace Manager</param>
    /// <returns>XML Document</returns>
    internal static XmlDocument GetSvgDocument(string? content, out XmlNamespaceManager manager)
    {
        var svg = new XmlDocument();
        svg.LoadXml(content);
        var navigator = svg.CreateNavigator();
        manager = new XmlNamespaceManager(navigator.NameTable);
        manager.AddNamespace(asset_svg_tag, asset_svg_name_space);
        return svg;
    }

    /// <summary>
    /// Get SVG Node
    /// </summary>
    /// <param name="svg">SVG Document</param>
    /// <param name="id">Id</param>
    /// <param name="manager">XML Namespace Manager</param>
    /// <returns>XML Node</returns>
    internal static XmlNode GetSvgNode(XmlDocument svg, string id, XmlNamespaceManager manager) => 
        svg.SelectSingleNode(string.Format(asset_svg_id, id), manager);

    /// <summary>
    /// Get SVG Fill Node
    /// </summary>
    /// <param name="svg">SVG Document</param>
    /// <param name="id">Id</param>
    /// <param name="manager">XML Namespace Manager</param>
    /// <returns>XML Node</returns>
    internal static XmlNode GetSvgFillNode(XmlDocument svg, string id, XmlNamespaceManager manager) =>
        svg.SelectSingleNode(string.Format(asset_svg_id_attribute, id, asset_svg_fill), manager);

    /// <summary>
    /// Get SVG Stroke Node
    /// </summary>
    /// <param name="svg">SVG Document</param>
    /// <param name="id">Id</param>
    /// <param name="manager">XML Namespace Manager</param>
    /// <returns>XML Node</returns>
    internal static XmlNode GetSvgStrokeNode(XmlDocument svg, string id, XmlNamespaceManager manager) =>
        svg.SelectSingleNode(string.Format(asset_svg_id_attribute, id, asset_svg_stroke), manager);

    /// <summary>
    /// Pad 
    /// </summary>
    /// <param name="source">Source Colours</param>
    /// <param name="pad">Pad Colour</param>
    /// <param name="total">Total Colours</param>
    /// <returns>Padded Colours</returns>
    internal static Color[] Pad(Color[]? source, Color pad, int total)
    {
        source ??= [];
        var result = new Color[total];
        if (source?.Length < total)
        {
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i];
            for (int i = source.Length; i < total; i++)
                result[i] = pad;
        }
        else
            Array.Copy(source, result, total);
        return result;
    }
}
