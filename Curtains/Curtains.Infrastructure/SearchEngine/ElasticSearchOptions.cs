namespace Curtains.Infrastructure.SearchEngine;

public class ElasticSearchOptions
{
    public const string Name = "ElasticSearch";

    public string Url = "http://localhost:9200";

    public string DefaultIndex { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public string ReservedCharactersPattern { get; set; }
}