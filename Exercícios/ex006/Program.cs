
 class Program {

    public static void Main() {

        string[] sonho = new string[3];
        int[] tempo = new int[3];

        int soma = 0;

        sonho[0] = "Finalizar a escola";
        sonho[2] = "Arranjar um emprego";
        sonho[1] = "Ter uma casa propria";

        tempo[1] = 10;
        tempo[0] = 1;
        tempo[2] = 4;

        for (int i = 0; i < sonho.Length; i++) {

            Console.WriteLine($"Os meus sonhos são: {sonho[i]} e levará {tempo[i]} ano");

            soma = soma + tempo[i];
        }

        Console.WriteLine($"Levará {soma} ano para realizar os meus sonhos");


    }
 }