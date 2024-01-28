using System.ComponentModel.DataAnnotations;

namespace New_ATCSharp.Models
{
    public class PilotoViewModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do carro")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a Idade do carro")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "Digite a Equipe do carro")]
        public string Equipe { get; set; }
        [Required(ErrorMessage = "Digite quantas corridas foram ganhas")]
        public int CorridasGanhas { get; set; }

        public DateTime Data { get; set; }

    }
}
