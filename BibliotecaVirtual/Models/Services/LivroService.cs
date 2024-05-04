using BibliotecaVirtu.Models.DTOs;
using BibliotecaVirtu.Models.Interfaces.Repositorys;
using BibliotecaVirtu.Models.Interfaces.Services;
using System;

namespace BibliotecaVirtu.Models.Servise
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public void Atualizar(LivroDTO livro)
        {
            try
            {
                _livroRepository.Atualizar(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(LivroDTO livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LivroDTO> listar()
        {
            try
            {
                return _livroRepository.listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public LivroDTO PesquisarPorId(string id)
        {
            try
            {
                return _livroRepository.PesquissrPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
