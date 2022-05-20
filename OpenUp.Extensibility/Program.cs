using static System.Console;
// See https://aka.ms/new-console-template for more information

using OpenUp.Extensibility;

var virusVIH = new VIH { Nome = "VIH/SIDA", EscalaVirus = 2};

var t = new Tratamento {AdministracaoDeFarmacos = 3, Hora = DateTime.Now.AddHours(8)};

var virusCovid19 = new SARSCov2 { Nome = "Covid19", PropriedadeTratamento = t };

List<ITransmissivel> virus = new();

virus.Add(virusVIH);
virus.Add(virusCovid19);

foreach (var v in virus)
{
    WriteLine(v.Transmitir());
}

HashSet<int> num = new(){1, 2, 3};
HashSet<int> num2 = new(){1, 3, 2};


// WriteLine($"O nome do vírus é: {virusVIH.Nome}");
// WriteLine($"O nome do vírus é: {virusCovid19.Nome}");



