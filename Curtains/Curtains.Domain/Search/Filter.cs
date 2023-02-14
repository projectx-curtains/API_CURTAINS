
namespace Curtains.Domain.Search
{
    public class Filter
    {
		public IList<string>? Fabric { get; set; }
		public IList<string>? CurtainsTypes { get; set; }
		public IList<string>? CurtainsKind { get; set; }
		public IList<string>? Purpose { get; set; }
		public IList<string>? Materials { get; set; }
        public IList<string>? FabricStructure { get; set; }
		public IList<string>? Colors { get; set; }
		public IList<string>? Design { get; set; }
		public IList<string>? Bracing { get; set; }
	}
}
