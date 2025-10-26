namespace GrindIt_.Models;

/// <summary>
/// Makes language display more intuitive in UX
/// </summary>
public class CultureItem
{
    /// <summary>
    /// Name of the language
    /// ex: English, Français, etc...
    /// </summary>
    public required string Name { get; init; }
    
    /// <summary>
    /// Code of the .resx file
    /// ex: en, fr-FR, etc...
    /// </summary>
    public required string Code { get; init; }
    
    /// <summary>
    /// Returns the <c>Name</c> of the CultureItem selected
    /// </summary>
    /// <remarks>
    /// I use it because other way it shows "GrindIt_.CultureItem"
    /// </remarks>
    /// <returns>A string that represents the CultureItem name</returns>
    public override string ToString() => Name;
}