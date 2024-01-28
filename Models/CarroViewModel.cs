using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_ATCSharp.Models
{
    public class CarroViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite a Marca do carro")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Digite o Modelo do carro")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Digite a Cor do carro")]
        public string Cor { get; set; }
        [Required(ErrorMessage = "Digite a Potência do carro")]
        public int Potencia { get; set; }
        [NotMapped]
        public IFormFile? Upload {  get; set; }

        public string? CarImgFileName { get; set; }
    }
}
