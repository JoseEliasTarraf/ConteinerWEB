using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WEBTest.Models.Enums;

namespace WEBTest.Models
{
    public class Conteiner
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Client Required")]
        public string? Cliente { get; set; }
        public string?  Numero { get; set; } = Guid.NewGuid().ToString("N");
        [Required(ErrorMessage = "Type Required")]
        public int Tipo { get; set; }
        [Required(ErrorMessage = "Category Required")]
        public Categoria? Categoria { get; set; }
        [Required(ErrorMessage = "Status Required")]
        public Status? Status { get; set; }
        public ICollection<Movimentações>? Movimentações { get; set; }

        public Conteiner() { }

        public Conteiner(int id, string? cliente, string numero, Categoria categoria, Status status)
        {
            Id = id;
            Cliente = cliente;
            Numero = numero;
            Categoria = categoria;
            Status = status;
        }
    }
}
