using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Varken : Dier
    {

        public Varken(int gewicht)
        {
            Gewicht = gewicht;
            uitspraak = "groink";
            geluid = "pig-sound.mp3";
        }


    }
}
