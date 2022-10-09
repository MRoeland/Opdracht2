// See https://aka.ms/new-console-template for more information


using Oefening1;

Koe koe = new Koe(80);

Slang slang = new Slang(10);
Varken varken = new Varken(50);

Console.WriteLine("Koe: gewicht = " + koe.Gewicht + " | Uitspraak = " + koe.Zegt() + " | Geluid = " + koe.geluid);
Console.WriteLine("Slang: gewicht = " + slang.Gewicht + " | Uitspraak = " + slang.Zegt() + " | Geluid = " + slang.geluid);
Console.WriteLine("varken: gewicht = " + varken.Gewicht + " | Uitspraak = " + varken.Zegt() + " | Geluid = " + varken.geluid);