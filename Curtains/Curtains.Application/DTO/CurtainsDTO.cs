namespace Curtains.Application.DTO
{
    public class CurtainsDTO
    {
        /// <summary>
        /// Curtain title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Curtain height
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Curtain width
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// The number of such curtains in the order
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  This property represents purpose of curtains.
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        ///  This property represents FabricId column.
        /// </summary>
        public int FabricId { get; set; }
        /// <summary>
        ///  This property represents MaterialId column.
        /// </summary>
        public int MaterialId { get; set; }
        /// <summary>
        ///  This property represents AccessoriesId column.
        /// </summary>
        public int AccessoriesId { get; set; }
        /// <summary>
        ///  This property represents CurtainsTypeId column.
        /// </summary>
        public int CurtainsTypeId { get; set; }
        /// <summary>
        ///  This property represents CurtainsKindId column.
        /// </summary>
        public int CurtainsKindId { get; set; }
        /// <summary>
        ///  This property represents ColorId column.
        /// </summary>
        public int ColorId { get; set; }
        /// <summary>
        ///  This property represents BrasingId column.
        /// </summary>
        public int BracingId { get; set; }
        /// <summary>
        ///  This property represents fabric of curtains.
        /// </summary>
        public FabricDTO Fabric { get; set; }
        public int Count { get; set; }
        /// <summary>
        /// Type of curtains
        /// </summary>
        public string CurtainsType { get; set; }
        /// <summary>
        /// Curtain fabric design
        /// </summary>
        public string Design { get; set; }
        /// <summary>
        /// Fabric type
        /// </summary>
        public string FabricType { get; set; }
        /// <summary>
        /// Curtain color
        /// </summary>
        public string Color { get; set; }
    }
}