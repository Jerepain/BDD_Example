using System.Collections.Generic;
using System.Linq;

namespace GoT
{
    public class Panier
    {
        List<Tome> tomes = new List<Tome>();

        public decimal? Total
        {
            get
            {
                if (tomes.Distinct().Count() >= 2)
                {
                    return tomes.Sum(t => t.Prix) * 0.95M;
                }
                return tomes.Sum(t => t.Prix);
            }
        }

        public void AjouterTome(Tome tome)
        {
            this.tomes.Add(tome);
        }
    }
}
