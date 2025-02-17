// See https://aka.ms/new-console-template for more information
List<string> words1 = ["habito", "hacer", "lectura", "sonreir"];
string order1 = "hlabcdfgijkmnopqrstuvwxyz";

var isAlienSorted =  new AlienDictionary().IsAlienSorted(words1, order1);
Console.WriteLine($"The words 1 is sorted: {isAlienSorted}");

List<string> words2 = ["habito", "hacer", "sonreir", "lectura"];
string order2 = "hlabcdfgijkmnopqrstuvwxyz";

isAlienSorted =  new AlienDictionary().IsAlienSorted(words2, order2);
Console.WriteLine($"The words 2 is sorted: {isAlienSorted}");

List<string> words3 = ["conocer", "cono"];
string order3 = "abcdefghijkmnopqrstuvwxyz";

isAlienSorted =  new AlienDictionary().IsAlienSorted(words3, order3);
Console.WriteLine($"The words 3 is sorted: {isAlienSorted}");