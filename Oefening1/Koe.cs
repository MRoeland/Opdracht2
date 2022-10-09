using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Koe : Dier
    {
        
        public Koe(int gewicht)
        {
            Gewicht = gewicht;
            uitspraak = "boe";
            geluid = "Cow-moo-sound.mp3";
        }
        
        
    }
}
