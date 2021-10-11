using System;
using Dio.series;

namespace series.Classes
{
    public class Serie : EntityBase
    {
        private Genero Genero { get; set; }
        private string Title { get; set;  }
        private string Description { get; set; }
        private int Year { get; set; }

        private bool Excluded { get; set; }
 
        public Serie(int id, Genero genero, string title, string description, int year)
        {
            this.Id = id;
            this.Genero = genero;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Excluded = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Title + Environment.NewLine;
            retorno += "Descrição: " + this.Description + Environment.NewLine;
            retorno += "Ano de Início: " + this.Year + Environment.NewLine;
            retorno += "Excluído: " + this.Excluded;

            return retorno;
        }

        public string returnTitle()
        {
            return this.Title;
        }

        public int returnId()
        {
            return this.Id;
        }

        public bool returnExcluded()
        {
            return this.Excluded;
        }

        public void Exclude()
        {
            this.Excluded = true;
        }
    }
}
