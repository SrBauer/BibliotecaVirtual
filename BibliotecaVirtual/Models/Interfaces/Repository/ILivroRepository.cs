using BibliotecaVirtu.Models.DTOs;

namespace BibliotecaVirtu.Models.Interfaces.Repositorys
{
    public interface ILivroRepository
    {
        void Cadastrar(LivroDTO livro);
        List<LivroDTO> listar();

        LivroDTO PesquissrPorId(string id);

        void Atualizar(LivroDTO livro);
    }
}

