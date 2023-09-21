namespace Models
{
    public class ContaCorrente
    {

        private string titular { get; set; }
        private double saldo { get; set; }

        public ContaCorrente(string titular)
        {
            this.titular = titular;
            this.saldo = 0;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo disponivel para {titular} é de {saldo}");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito do valor {valor}");
            } else
            {
                Console.WriteLine("Valor inválido para depósitar no banco.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor}");
            } else
            {
                Console.WriteLine($"Valor inválido para saque ou saldo insufuciente");
            }
        }

    }


}