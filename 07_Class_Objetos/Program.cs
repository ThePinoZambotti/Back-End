using Sesi.Model;

class Program {

    public static void Main() {
        
        //Criando uma variável aluno1 e instanciando da class Aluno
        //Criando nosso objeto
        var aluno1 = new Aluno();
        aluno1.nome = "Pino";
        aluno1.idade = 17;
        aluno1.turma = "2º Em";
        
        //Chamando o método da classe Aluno
        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Queconi";
        aluno2.idade = 18;
        aluno2.turma = "3º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();
        aluno2.ResumoFaltas();
    }
}