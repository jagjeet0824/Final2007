using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2007w2018finalB.Models
{
    public interface IMockBreweryRepository
    {
        IQueryable<Brewery> Breweries { get; }
        void Save(Brewery brewery);
    }
}
