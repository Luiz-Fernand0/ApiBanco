using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiInova.ApiService.Models.Models2
{
    public class TransacaoModel
    {
        [Key]
        public int Id { get; set; } 

        [Column(TypeName = "decimal(18,2)")] // Valores monetários
        public decimal Valor { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string TipoTransacao { get; set; } // Saque, deposito ...

        public int ContaID { get; set; } 

        [ForeignKey(nameof(ContaID))]
        public ContaModel Conta { get; set; }
    }
}
