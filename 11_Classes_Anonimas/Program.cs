public class Program
{
    public static void Main()
    {
        var pessoa1 = new {
              nome = "João",
              idade = 20
            };
        var pessoa2 = new {
              nome = "Maria",
              idade = 17
            };
            Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");


            Console.WriteLine("Digite o marca do carro");
            string modeloDigitado = Console.ReadLine();
            Console.WriteLine("Digite a modelo do carro");
            string marcaDigitado = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro");
            string anoDigitado = Console.ReadLine();

            var carro1 = new {
                marca = marcaDigitado,
                modelo = modeloDigitado,
                ano = anoDigitado
            };

            Console.WriteLine($"A marca do Carro é {marcaDigitado} e o Modelo é {modeloDigitado} e o Ano é {anoDigitado}");

    }
}