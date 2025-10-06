using System.ComponentModel.DataAnnotations;

namespace LektierOpg1til6.Models
{
    public class Product
    {
        // Unikt ID for hvert produkt
        public int Id { get; set; }

        // Produktets navn, påkrævet og maks 50 tegn

        [Required]
        [StringLength(50, ErrorMessage = "Name must be less than 50 characters.")]
        public string Name { get; set; }

        // Produktets pris, påkrævet
        [Required]
        public decimal Price { get; set; }

        // Beskrivelse af produktet
        public string Description { get; set; }

        // Angiver om produktet er publiceret
        public bool IsPublished { get; set; }
        
        
        // Dato for hvornår produktet blev oprettet/publiseret
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        // Type af produkt, fx Glas, Plastik osv., påkrævet
        [Required]
        public string ProductType { get; set; } = string.Empty;
    }
}
