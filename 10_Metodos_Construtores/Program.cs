using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto de classe Pessoa
        /*
        
        //Instanciando objeto sem método construtor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Adalberto";
        pessoa1.idade = 16;

        //Alternativa de um objeto instanciando sem construtor
        Pessoa pessoa1 = new Pessoa {
            nome = "Pino",
            idade = 17
        }
        */

        //Instanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("Alberto Roberto", 16);
        Pessoa pessoa2 = new Pessoa("Pino", 15);
        Pessoa pessoa3 = new Pessoa("Paulo", 17);

        //Chamando o método Cantar da classe
        pessoa1.Cantar();
        pessoa2.Cantar();
        pessoa3.Cantar();
    }
    
}
