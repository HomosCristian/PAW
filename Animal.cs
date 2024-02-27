using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Seminar1
{
    internal class Animal:ICloneable, IComparable      //astea de dupa : sunt interfete
    {
        private int varsta;
        private string nume;
        private float greutate;

        //propietati
        public int Varsta {  get { return varsta; } 
            set { if(value>0) varsta = value; } }

        public string Nume { get { return nume; } 
            set { if (value.Length > 3) nume = value; } }

        private float Greutate {  get { return greutate; } 
            set {  if(value>0) greutate = value; } }

        //constructor cu cei 3 parametrii

        public Animal(int v, string n, float g)
        {
            varsta = v;
            nume= n;
            greutate= g;
        }
        public override string ToString()
        {
            return "Animalul "+ nume + " are varsta " + varsta + " si greutatea " + greutate;
        }

        //implementare IClonable

        //superficiala (shallow copy)

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
        public Animal Clone()
        {
            return (Animal)((ICloneable)this).Clone();
        }

        public int CompareTo(object obj)
        {
            Animal nou=(Animal)obj;
            if (this.greutate > nou.greutate) return 1;
            else if (this.greutate < nou.greutate) return -1;
            else return string.Compare(this.nume, nou.nume);
        }


    }
}
