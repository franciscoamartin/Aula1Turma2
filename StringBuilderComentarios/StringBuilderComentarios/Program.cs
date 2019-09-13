using System;
using StringBuilderComentarios.Entities;

namespace StringBuilderComentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("have a nice day!");
            Comment c2 = new Comment("Hello man!");
            Post post = new Post(DateTime.Parse("10/02/2019 12:12:22"),
                "Titulo aqui",
                "Grande conteudo aqui",
                50);
            post.AddComment(c1);
            post.AddComment(c2);

            Comment c3 = new Comment("outro comentario");
            Comment c4 = new Comment("quarto comentario");
            Post post1 = new Post(DateTime.Parse("20/02/2019 13:13:22"),
                "Titulo aqui de novo",
                "Grande conteudo aqui de novo",
                50);
            post.AddComment(c3);
            post.AddComment(c4);

            Console.WriteLine( post );
            Console.WriteLine();
            Console.WriteLine(post1);







        }
    }
}
