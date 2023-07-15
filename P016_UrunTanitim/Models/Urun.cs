namespace P016_UrunTanitim.Models
{
	public class Urun
	{
        /*!!! -> Bir model, sadece property lerden oluşmalıdır.*/
        //SOLID
        //node
        public int Id { get; set; } //Identity //Guid
        public string? UrunKodu { get; set; }
        public string UrunTanim { get; set; } //Max

        public int Miktar { get;set; }
        public string UrunTur { get; set; }
        public int MinStokSeviyesi { get; set; }
        public int MaxStokSeviyesi { get; set; }
    }
}
//Normalizasyon
