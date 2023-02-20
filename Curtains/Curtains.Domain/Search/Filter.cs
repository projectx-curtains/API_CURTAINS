
namespace Curtains.Domain.Search
{
    public class Filter
    {
		/// <summary>
		/// This property is a list of curtain fabric names.
		/// </summary>
		public IList<string>? Fabric { get; set; }
		/// <summary>
		/// This property is a list of curtain type names.
		/// </summary>
		public IList<string>? CurtainsTypes { get; set; }
		/// <summary>
		/// This property is a list of curtain kind names.
		/// </summary>
		public IList<string>? CurtainsKind { get; set; }
		/// <summary>
		/// This property is a list of curtain purpose names.
		/// </summary>
		public IList<string>? Purpose { get; set; }
		/// <summary>
		/// This property is a list of curtain material names.
		/// </summary>
		public IList<string>? Materials { get; set; }
		/// <summary>
		/// This property is a list of fabric composition.
		/// </summary>
		public IList<string>? FabricStructure { get; set; }
		/// <summary>
		/// This property is a list of curtain color names.
		/// </summary>
		public IList<string>? Colors { get; set; }
		/// <summary>
		/// This property is a list of curtain design names.
		/// </summary>
		public IList<string>? Design { get; set; }
		/// <summary>
		/// This property is a list of curtain bracing names.
		/// </summary>
		public IList<string>? Bracing { get; set; }
	}
}
