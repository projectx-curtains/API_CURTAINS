namespace Curtains.Domain.Projections
{
    public class CurtainsProjection
    {
        public int Id { get; set; }             
        public string Title{ get; set; }          
        public string Description { get; set; }
        public string Purpose { get; set; }     
        public decimal Price { get; set; }        
        public bool Density { get; set; }         
        public bool SunProtection { get; set; }  
        public int Height { get; set; }           
        public int Width { get; set; }   
        public int FabricId { get; set; }   // +++
        public int ColorId { get; set; }    // ???
        public int MaterialId { get; set; }  // +++
        public int CurtainsTypeId { get; set; } // +++
        public int CurtainsKindId { get; set; }  // +++
    }
}