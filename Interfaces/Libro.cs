using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Libro : IColeccionable, IComparable<Libro>
    {
        private string autor;
        private string titulo;

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        public Libro(string autor, string titulo)
        {
            this.autor = autor;
            this.titulo = titulo;
        }

        public int CompareTo(Libro otro)
        {
            return String.Compare(this.titulo, otro.titulo);
        }

        public String Describir()
        {
            return "Titulo: " + titulo + ", del autor " + autor;
        }
    }
}
