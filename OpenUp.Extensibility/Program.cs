using static System.Console;
// See https://aka.ms/new-console-template for more information

using OpenUp.Extensibility;

var virusVIH = new VIH { Nome = "VIH/SIDA", EscalaVirus = 2};

var virusCovid19 = new SARSCov2 { Nome = "Covid19" };

List<ITransmissivel> virus = new();

virus.Add(virusVIH);
virus.Add(virusCovid19);

foreach (var v in virus)
{
    WriteLine(v.Transmitir());
}


// WriteLine($"O nome do vírus é: {virusVIH.Nome}");
// WriteLine($"O nome do vírus é: {virusCovid19.Nome}");



