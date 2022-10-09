using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Varken : Dier
    {

        public Varken(int gewicht)
        {
            Gewicht = gewicht;
            uitspraak = "groink";
            geluid = "pig_squeal.wav";
        }


    }
}
