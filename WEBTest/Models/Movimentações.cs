using System.ComponentModel.DataAnnotations;
using WEBTest.Models.Enums;

namespace WEBTest.Models
{
    public class Movimentações
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Type Required")]
        public Tipo Tipo { get; set; }
        [Required(ErrorMessage = "Initial Date Required")]
        public DateTime DataInitial { get; set; } = new DateTime(DateTime.Now.Hour);
        [Required(ErrorMessage = "Final Date Required")]
        public DateTime DataFinal { get; set; } = new DateTime(DateTime.Now.Hour);
        [Required(ErrorMessage = "Conteiner ID Required")]
        public int ConteinerId { get; set; }
        public Conteiner? Conteiner { get; set; }


        public Movimentações() { }

        public Movimentações(int id, Tipo tipo, DateTime dataInitial, DateTime dataFinal, int conteinerId, Conteiner? conteiner)
        {
            Id = id;
            Tipo = tipo;
            DataInitial = dataInitial;
            DataFinal = dataFinal;
            ConteinerId = conteinerId;
            Conteiner = conteiner;
        }
    }
}
