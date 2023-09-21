Console.WriteLine("Digite a placa do carro:");
string placa = Console.ReadLine();

string  final = placa.Substring(placa.Length -1, 1);

if (final == "1" || final == "2") {
    Console.WriteLine("Você não pode sair em SP na segunda feira");
} else  if (final == "3" || final == "4") {
    Console.WriteLine("Você não pode sair em SP na terça feira");
} else if (final == "5" || final == "6") {
    Console.WriteLine("Você não pode sair em SP na quarta feira");
} else if (final == "7" || final == "8") {
    Console.WriteLine("Vocênão pode sair em SP na quinta feira");
} else if (final)