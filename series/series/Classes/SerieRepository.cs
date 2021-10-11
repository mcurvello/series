using System;
using System.Collections.Generic;
using series.Classes;
using series.Interfaces;

namespace series
{
    public class SerieRepository:IRepository<Serie>
    {

        private List<Serie> listSerie = new List<Serie>();
        public SerieRepository()
        {
        }

        public void Exclude(int id)
        {
            listSerie[id].Exclude();
        }

        public void Insert(Serie entity)
        {
            listSerie.Add(entity);
        }

        public List<Serie> List()
        {
            return listSerie;
        }

        public int NextId()
        {
            return listSerie.Count;
        }

        public Serie ReturnFromId(int id)
        {
            return listSerie[id];
        }

        public void Update(int id, Serie entity)
        {
            listSerie[id] = entity;
        }
    }
}
