using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleMVCApp.Models
{
    [Table("Prodotti")]
    public class Prodotto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome del prodotto è obbligatorio.")]
        [StringLength(255, ErrorMessage = "Il nome del prodotto non può superare i 255 caratteri.")]
        public string NomeProdotto { get; set; }

        [Required(ErrorMessage = "La quantità è obbligatoria.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "La quantità deve essere maggiore di 0.")]
        public decimal Quantita { get; set; }

        [StringLength(10000, ErrorMessage = "Le note non possono superare i 1000 caratteri.")]
        public string Note { get; set; }
    }
}
