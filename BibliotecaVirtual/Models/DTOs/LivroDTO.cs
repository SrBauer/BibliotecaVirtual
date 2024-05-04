using BibliotecaVirtu.Models.Interfaces;

namespace BibliotecaVirtu.Models.DTOs
{
    public class LivroDTO : InterfaseBase
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public LivroDTO() { }

        public LivroDTO(string Id, string Nome, string Autor, string Editora)
            : this(Nome, Autor, Editora)
        {
            this.Id = Id;
        }

        public LivroDTO(string Nome, string Autor, string Editora)
        {
            this.Nome = Nome;
            this.Autor = Autor;
            this.Editora = Editora;
        }
    }
}
