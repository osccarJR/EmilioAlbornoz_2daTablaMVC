namespace EmilioAlbornoz_WebCF.Models
{
    public class Promo
    {

        public int PromoID { get; set; }
        public string? Descripcion { get; set; }
        public DateTime BurgerID { get; set; }

        public Burger? Burger { get; set; }
    }
}
