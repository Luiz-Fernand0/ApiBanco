using ApiInova.ApiService.Models.Models2;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiInova.ApiService.Models
{
    public class ContaModel
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(14)")]
        [MaxLength(14)]
        public string Cnpj { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        [MaxLength(12)]
        public string ContaAgencia { get; set; }

        [Required]
        [Column(TypeName = "varchar(4)")]
        [MaxLength(4)]
        public string Agencia { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[] DocumentoCli { get; set; }

        public List<TransacaoModel> Transacoes { get; set; } = new List<TransacaoModel>(); // Evita null
    }
}
