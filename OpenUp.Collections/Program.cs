// See https://aka.ms/new-console-template for more information

//Conjunto
using System.Collections.Generic;
using System.Collections.Immutable;

var frutas = new List<string>{ "Tomate", "Maca", "Pera", "Laranja"};

var vegetais = new HashSet<string>{ "Pimento", "Cenoura", "Milho", "Tomate"};

var cereais = new HashSet<string>{ "Arroz", "Milho", "Trigo"};

var graos = new HashSet<string>{ "Arroz", "Milho", "Feijao"};

var frutasVegetais = frutas.Intersect(vegetais);

var cereaisGraos = cereais.Intersect(graos);

var contemLetraO = vegetais.Where(v => v.Contains("o"));


// foreach (var item in frutasVegetais)
// {
//     Console.WriteLine($"Fruto e vegetal:  " + item);    
// }

// foreach (var item in cereaisGraos)
// {
//     Console.WriteLine($"Cereal e grao: " + item);    
// }

// // Dicionarios / Mapa

// Dictionary<string, string> produtos = new();

// foreach (var item in cereais)
// {
//     produtos.Add(key: item.Substring(0,2), value: item);
// }

// foreach (var item in frutas)
// {
//     produtos.Add(key: item.Substring(0,3), value: item);
// }


// foreach (var item in graos)
// {
//     produtos.Add(key: item.Substring(0,4), value: item);
// }

// foreach (var item in produtos)
// {
//      Console.WriteLine($"Codigo " + item.Key + ", Valor: " + item.Value);
// }

// Console.WriteLine($"Produtos " + produtos.Count());

// ImmutableList<string> immutableCities = cereais.ToImmutableList();