using System;

namespace PPilhaDinamica2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivros minhaPilha = new PilhaLivros();

            minhaPilha.Print();

            Livro livro = new Livro("Poeira em alto mar", 1234, "Gabi");
            minhaPilha.Push(livro);

            minhaPilha.Push(new Livro("Só os loucos sabem", 3214, "Charlie"));

            minhaPilha.Print();

            minhaPilha.Pop();
            minhaPilha.Print();

            minhaPilha.Pop();
            minhaPilha.Print();

            minhaPilha.Pop();
            



        }
    }
}
