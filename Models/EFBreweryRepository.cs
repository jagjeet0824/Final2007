using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace comp2007w2018finalB.Models
{
    public class EFBreweryRepository : IMockBreweryRepository
    {
        // database connection
        private CraftBrewingModel db = new CraftBrewingModel();

        public IQueryable<Brewery> Breweries { get { return db.Breweries; } }

        public void Save(Brewery brewery)
        {
            if (brewery.BreweryId == 0)
            {
                db.Breweries.Add(brewery);
            }
            else
            {
                db.Entry(brewery).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();
        }
    }
}