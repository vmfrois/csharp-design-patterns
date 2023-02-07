namespace Design.Patterns.Application.Strategy.Models
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

    }
}
