public class Program
{
    public static void Main()
    { 

      //O try serve para tratar um erro enão parar a execução do programa
      //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
      //a execução do bloco e vai para o catch  
      try {   
           Console.WriteLine("Digite um número inteiro");
           int numero = int.Parse(Console.ReadLine());
           Console.WriteLine($"Você digitou o n° {numero}");
        }
        catch (OverFlowException)
        {
            Console.WriteLine($"O número digitado atingiu o limite maximo")
        }

        //Tratando exceção de erro específica de formato
        catch (FormatException)
        {
            Console.WriteLine("Digite um número inteiro");
        }

        //catch é o tratamento do erro, normalmente colocamos as mensagens de acordo
        //com o tipo de erro, para melhor compreensão do usúario
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro genérico: {erro.Message}");
        }
        finally{
            Console.WriteLine($"No bloco finally o programa entra independentemente de execeção");
        }
    }
}