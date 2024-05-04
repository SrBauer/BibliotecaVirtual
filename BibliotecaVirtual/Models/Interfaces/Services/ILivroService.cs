using BibliotecaVirtu.Models.DTOs;

namespace BibliotecaVirtu.Models.Interfaces.Services
{
    public interface ILivroService
    {
        void Cadastrar(LivroDTO livro);
        List<LivroDTO> listar();

        LivroDTO PesquisarPorId(string id);

        void Atualizar(LivroDTO livro);

        void Excluir(string id);
    }
}

