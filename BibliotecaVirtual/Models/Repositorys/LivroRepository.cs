using BibliotecaVirtu.Models.DTOs;
using BibliotecaVirtu.Models.Interfaces.Repositorys;

namespace BibliotecaVirtu.Models.Repositorys
{
    public class LivroRepository : ILivroRepository
    {
        public void Atualizar(LivroDTO livro)
        {
            var objPesquisa = PesquissrPorId(livro.Id);
            ContextDateFake.Livros.Remove(objPesquisa);

            objPesquisa.Nome = livro.Nome;
            objPesquisa.Autor = livro.Autor;
            objPesquisa.Editora = livro.Editora;

            Cadastrar(objPesquisa);
        }

        public void Cadastrar(LivroDTO livro)
        {
            ContextDateFake.Livros.Add(livro);
        }

        public void Excluir(string id)
        {
            var objPesquisa = PesquissrPorId(id);
            ContextDateFake.Livros.Remove(objPesquisa);
        }

        public List<LivroDTO> listar()
        {
            var livros = ContextDateFake.Livros;
            return livros.OrderBy(p => p.Nome).ToList();
        }

        public LivroDTO PesquissrPorId(string id)
        {
            var livro = ContextDateFake.Livros.FirstOrDefault(p => p.Id == id);
            return livro;
        }
    }
}

