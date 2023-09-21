Console.WriteLine("Digite o número do mês:");
string mes = Console.ReadLine();

switch (mes) {
    case "1":
        Console.WriteLine("Janeiro com 31 dias!");
        break;
    case "2":
        Console.WriteLine("Fevereiro com 28 ou 29 dias!");
        break;
    case "3":
        Console.WriteLine("Abril com 30!");
        break;
    case "4":
        Console.WriteLine("Maio com 31 dias!");
        break;
    case "5":   
        Console.WriteLine("Junho com 30 dias!");
        break;
    case "6":
        Console.WriteLine("Julho com !");
        break;
    case 7: 
        Console.WriteLine("Hoje é Sábado!");
        break;
    default:
        Console.WriteLine("Dia inválido");
}