using Models;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Bem-vindo ao Banco do Pino");
        Console.WriteLine("-----------------------------");

        Thread.Sleep(2000);


        Menu();
    }

    public static void Menu()
    {
        string opcao = "";

        Console.WriteLine("Informe o nome do titular");
        string nomeTitular = Console.ReadLine();

        ContaCorrente conta = new ContaCorrente(nomeTitular);

        do {
            Console.WriteLine("---------- M E N U ----------");
            Console.WriteLine("1- Para Consultar o saldo");
            Console.WriteLine("2- Para Depositar");
            Console.WriteLine("3- Para Sacar");
            Console.WriteLine("0- Para Sair da Conta");
            Console.WriteLine("-----------------------------");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao) {
                case  "0":
                    Console.WriteLine("Obrigado, volte sempre!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case  "1":
                    conta.ConsultarSaldo();
                    break;   
                case "2":
                    Console.WriteLine("Informe o valor a ser depositado");
                    double valorDep = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDep);
                    break;
                case "3":
                    Console.WriteLine("Informe o valor a ser sacado");
                    double valorSac = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSac);
                    break;             
                default:
                    Console.WriteLine("Opção inválida!");
                    break;    
            }

        } while (opcao != "0");
        
    }

}