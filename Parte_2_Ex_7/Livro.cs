﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_7
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponivel { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponivel = true; // Livro está disponível quando é criado
        }
    }
}