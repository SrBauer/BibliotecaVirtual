using BibliotecaVirtu.Models.DTOs;
using System;
using System.Collections.Generic;

namespace BibliotecaVirtu.Models.Repositorys

//Banco de dados fake para acessar informações
{
    public static class ContextDateFake
    {
        public static List<LivroDTO> Livros;

        static ContextDateFake()
        {
            Livros = new List<LivroDTO>();
            InitializeDate();
        }

        private static void InitializeDate()
        {
            var livro = new LivroDTO("Inplementando Domain-Driven Design", "Vaugt Vernon", "alta Books");
            Livros.Add(livro);

            livro = new LivroDTO("Clean Code: A Handbook of Agile Software Craftsmanshipn", " Robert C. Martin", "Prentice Hall");
            Livros.Add(livro);

            livro = new LivroDTO("The Pragmatic Programmer: Your Journey to Mastery", "Andrew Hunt, David Thomas", "Addison-Wesley Professional");
            Livros.Add(livro);

            livro = new LivroDTO("Design Patterns: Elements of Reusable Object-Oriented Software", " Erich Gamma", "Addison-Wesley Professional");
            Livros.Add(livro);

            livro = new LivroDTO("Refactoring: Improving the Design of Existing Code", "Martin Fowler", " Addison-Wesley Professional");
            Livros.Add(livro);
        }
    }
}

