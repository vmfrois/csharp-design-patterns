using Design.Patterns.Application.ChainOfResponsibility.Models;
using Design.Patterns.Application.ChainOfResponsibility.Services.Interfaces;

namespace Design.Patterns.Application.ChainOfResponsibility.Services
{
    public class DescontoPorMilReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            // Regra de negocio -> Se o valor do orçamento for mais que mil, desconta 50%
            if(orcamento.Valor > 1000)
            {
                return orcamento.Valor * 0.50;
            }


            // Usamos a Propriedade Proximo, que é a Interface IDesconto
            // Para chamar o ChainOfResposibily, sendo assim vai chamar o proximo desconto
            // Mas como é uma interface, ela nao sabe qual irá puxar
            return Proximo.Desconta(orcamento);
        }
    }
}
