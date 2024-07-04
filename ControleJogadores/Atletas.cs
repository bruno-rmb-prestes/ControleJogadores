namespace ControleJogadores
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Atleta
    {
        [Key]
        public int AtletaID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Apelido { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        [Required]
        [StringLength(50)]
        public string Posicao { get; set; }

        [Required]
        [StringLength(2)]
        public string CamisaNro { get; set; }
    }
}
