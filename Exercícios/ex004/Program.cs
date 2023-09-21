
class Program {

    //Método de entrada
    public static void Main() {

        int Numero = int.Parse(Console.ReadLine());

        Console.WriteLine(Dobro(Numero));


        int Numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine(Divi(Numero2));


        Tabuada();

        SomarComWhile();
    }

    public static int Dobro(int n1) {

        int dobro  = n1 * 2;
        
        return dobro;
    }

    public static int Divi(int n2) {

        int div = n2 / 2;

        return div;
    }


    public static void Tabuada() {
        Console.WriteLine("Digite um numero");
        int num = int.Parse(Console.ReadLine());
        int contador = 1;

        while (contador <= 10) {
            Console.WriteLine($"{num} X {contador} = {num * contador}");
            contador++;
        }



    }

    public static void SomarComWhile() {

        int maior = 0;
        int menor = 10000;
        int soma = 0;
        int num = 0;

        do {

            Console.WriteLine("Informe um número positivo, negativo para encerrar");
            num = int.Parse(Console.ReadLine());

            if (num > maior) 
                maior = num;

            if (num < menor && num > 0)
                menor = num;

            if (num > 0)
            soma = soma + num; 
               
        } while (num > 0);
        Console.WriteLine($"Menor n° {menor} - maior n° {maior} - soma dos n° {soma}");
    }
}