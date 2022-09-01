using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhaDinamica2022
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }
        public Livro Anterior { set; get; }

        public Livro(string titulo, int ISBN, string autor)
        {
            this.Titulo = titulo;
            this.ISBN = ISBN;
            this.Autor = autor;
            this.Anterior = null;
            
        }

        public override string ToString()
        {
            return "\nDADOS DO LIVRO:\nTitulo: " + Titulo + "\nAutor: " + Autor + "\nISBN: " + ISBN;
        }


    }
}
