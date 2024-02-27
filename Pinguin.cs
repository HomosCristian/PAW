using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Pinguin:Animal
    {
        private bool areIglu;
        public bool AreIglu
        {
            get { return areIglu; }
            set { if (value != areIglu) areIglu = value; }
        }

        public Pinguin(bool i, int v, string n, float g) : base(v, n, g)
        {
            areIglu = i;
        }

        public override string ToString()
        {
            return base.ToString() + (areIglu ? " are Iglu " : "NU ARE Iglu");
        }
    }
}
