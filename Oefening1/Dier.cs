using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    abstract class Dier
    {

        public double Gewicht;
        private String Uitspraak;

        public String uitspraak
        {
            get { return Uitspraak; }
            set { Uitspraak = value; }
        }
        private String Geluid;

        public String geluid
        {
            get { return Geluid; }
            set { Geluid = value; }
        }

        public Dier()
        {

        }

        public Dier(double gewicht, string uitspraak, string geluid)
        {
            Gewicht = gewicht;
            Uitspraak = uitspraak;
            Geluid = geluid;
        }

        public String Zegt()
        {
            return Uitspraak;
        }

    }
}
