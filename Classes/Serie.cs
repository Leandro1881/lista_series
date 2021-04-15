using Projeto_2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_2.Classes
{
    class Serie : EntidadeBase
    {
        private Genero genero { get; set; }
        private string titulo { get; set; }
 
        private string descricao { get; set; }
        private int ano { get; set; }
        private bool excluido { get; set; }

        public Serie(int id, Genero g, string t, string d, int a)
        {
            this.Id = id;
            this.genero = g;
            this.titulo = t;
            this.ano = a;
            this.excluido = false;
        }
        public override string ToString()
        {
            string s = "";
            s += "Id: " + this.Id + Environment.NewLine;
            s += "Título: " + this.titulo + Environment.NewLine;
            s += "Genero: " + this.genero + Environment.NewLine;
            s += "Descrição: " + this.descricao + Environment.NewLine;
            s += "Ano: " + this.ano + Environment.NewLine;
            s += "Excluido: " + this.excluido;
            return s;
        }
        public string getTitulo()
        {
            return this.titulo;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public int getId()
        {
            return this.Id;
        }
        public void setExcluir(bool f)
        {
            this.excluido = f;
        }
        public bool getExcluir()
        {
            return this.excluido;
        }
    }
}
