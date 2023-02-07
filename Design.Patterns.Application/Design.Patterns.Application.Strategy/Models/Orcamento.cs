﻿namespace Design.Patterns.Application.Strategy.Models
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
        }

        public double getValor()
        {
            return Valor;
        }
    }
}
