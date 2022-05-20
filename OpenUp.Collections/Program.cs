// See https://aka.ms/new-console-template for more information

//Conjunto
using System.Collections.Generic;

var frutas = new HashSet<string>{ "Tomate", "Maca", "Pera", "Laranja"};


var vegetais = new HashSet<string>{ "Pimento", "Cenoura", "Milho", "Tomate"};

var cereais = new HashSet<string>{ "Arroz", "Milho", "Trigo"};

var graos = new HashSet<string>{ "Arroz", "Milho", "Feijao"};

var fruirasVegetais = frutas.Intersect(vegetais);

var cereaisGraos = cereais.Intersect(graos);


foreach (var item in fruirasVegetais)
{
    if (fruirasVegetais.Any())
        Console.WriteLine($"Fruto e vegetal: " + item);
    
}

foreach (var item in cereaisGraos)
{
    if (cereaisGraos.Any())
        Console.WriteLine($"Cereal e grao: " + item);
    
}

