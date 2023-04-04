namespace Curtains.Application.DTO
{
    public class CurtainSearchDTO
    {
        /// <summary>
        /// This property is an identifier for data tranfer object.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This property represents the price of curtains.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// This property is the name of fabric for curtains.
        /// </summary>
        public string Fabric { get; set; }
        /// <summary>
        /// This property is the name of curtains type.
        /// </summary>
        public string CurtainsType { get; set; }
        /// <summary>
        /// This property is the name of curtains kind.
        /// </summary>
        public string CurtainsKind { get; set; }
        /// <summary>
        /// This property is the name of purpose for curtains.
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        /// This property is the name of material for curtains.
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// This property represents the composition of curtains.
        /// </summary>
        public string FabricStructure { get; set; }
        /// <summary>
        /// This property represents whether the curtains are blackout or not.
        /// </summary>
        public bool Density { get; set; }
        /// <summary>
        /// This property represents situation, if curtains are sun-protected or not.
        /// </summary>
        public bool SunProtection { get; set; }
        /// <summary>
        /// This property is the color name for curtains.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// This property represents height of curtains.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// This property represents width of curtains.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// This property is the name of design for curtains.
        /// </summary>
        public string Desing { get; set; }
        /// <summary>
        /// This property is the name of bracing for curtains.
        /// </summary>
        public string Bracing { get; set; }
    }
}
