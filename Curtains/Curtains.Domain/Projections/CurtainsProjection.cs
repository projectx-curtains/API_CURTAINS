namespace Curtains.Domain.Projections
{
    public class CurtainsProjection
    {
        public Guid Id { get; set; }               // Айдишник
        public string Title{ get; set; }           // Титульник 
        public string Purpose { get; set; }        // Назначение штор
        public decimal Price { get; set; }         // Цена
        public bool Density { get; set; }          // Плотность ткани
        public bool SunProtection { get; set; }    // Защита от солнца 
        public int Height { get; set; }            // Высота
        public int Width { get; set; }             // Ширина
        public int FabricId { get; set; }          // Вид ткани
        public int ColorId { get; set; }           // Цвет
        public int MaterialId { get; set; }        // Состав ткани
        public int CurtainsTypeId { get; set; }    // Тип штор 
        public int CurtainsKindId { get; set; }    // Вид штор
    }
}