using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhaDinamica2022
{
    internal class PilhaLivros
    {
        public Livro TOPO { get; set; }

        public PilhaLivros()
        {
            this.TOPO = null;
            Console.WriteLine("Pilha criada com sucesso!");
        }

        public void Push (Livro aux)
        {
           if (Vazia())
               this.TOPO = aux;
           else
           {
                aux.Anterior = TOPO;
                this.TOPO = aux;


           }

        }

        public void Print()
        {
            if (Vazia())
                Console.WriteLine("Pilha vazia!");
            else
            {
                Livro aux = TOPO;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                }while (aux != null);
                Console.WriteLine("FIM DA IMPRESSÃO ");

            
            }
        }

        public void Pop()
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia!");
            else
            {
                TOPO = TOPO.Anterior;
            }
        }

        private bool Vazia()
        {
            if (TOPO == null)
                return true;
            else 
                return false;
        }
    }
}
