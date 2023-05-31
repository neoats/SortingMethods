namespace DataAccess;

public class Paths
{
    readonly string baseDirectory = "C:\\Users\\Fuat\\Desktop\\";
    readonly string sortingPatternDirectory;

    public Paths()
    {
        sortingPatternDirectory = Path.Combine(baseDirectory, "SortingMethods\\DataAccess\\Constants\\");

        _100k = Path.Combine(sortingPatternDirectory, "_100k.json");
        _10k = Path.Combine(sortingPatternDirectory, "_10k.json");
        _1k = Path.Combine(sortingPatternDirectory, "_1k.json");
        _1m = Path.Combine(sortingPatternDirectory, "_1m.json");
    }

    public string _100k { get; }
    public string _10k { get; }
    public string _1k { get; }
    public string _1m { get; }
}