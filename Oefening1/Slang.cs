using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Slang : Dier
    {

        public Slang(int gewicht)
        {
            Gewicht = gewicht;
            uitspraak = "ssj";
            geluid = "snake-hissing-sound.mp3";
        }


    }
}
