using System.ComponentModel.DataAnnotations;

namespace EmilioAlbornoz_WebCF.Models
{
    public class Burger
    {
        [Key] // This annotation is optional if you follow the convention
        public int BurgerID { get; set; } // Corrected the typo here

        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

        public List <Promo>? Promo { get; set; }
    }
}
