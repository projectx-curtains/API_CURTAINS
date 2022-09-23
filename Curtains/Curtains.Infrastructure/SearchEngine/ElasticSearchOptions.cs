namespace Curtains.Infrastructure.SearchEngine;

public class ElasticSearchOptions
{
    public const string Name = "ElasticSearch";

    public string Url { get; set; }

    public string DefaultIndex { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public string ReservedCharactersPattern { get; set; }
}