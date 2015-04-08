using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoT
{
    public class Tome
    {
        private int opus;

        public Tome(decimal prix)
        {
            this.Prix = prix;
        }

        public Tome(int opus, decimal prix)
        {
            this.opus = opus;
            this.Prix = prix;
        }

        public decimal? Prix { get; private set; }

        public int Opus
        {
            get
            {
                return opus;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            var otherTome = obj as Tome;
            if (otherTome == null) return false;

            return this.Opus == otherTome.Opus;
        }

        public override int GetHashCode()
        {
            return this.Opus.GetHashCode();
        }
    }
}
