using System;
using System.Collections.Generic;
using System.Text;

namespace Pensao
{
    class Quarto
    {
        internal object nomeInquilino;

        public string NomeInquilino { get; set; }
        public string EmailInquilino { get; set; }
        public int NumeroQuarto { get; set; }

        public Quarto() { }


        public Quarto(string nomeInquilino, string emailInquilino, int numeroQuarto)
        {
            NomeInquilino = nomeInquilino;
            EmailInquilino = emailInquilino;
            NumeroQuarto = numeroQuarto;
        }

        public override string ToString()
        {
            return NomeInquilino + "\n" + EmailInquilino + "\n" + NumeroQuarto;
        }
    }
}
