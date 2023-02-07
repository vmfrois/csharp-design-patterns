﻿using Design.Patterns.Application.Strategy.Models;
using Design.Patterns.Application.Strategy.Services;
using Design.Patterns.Application.Strategy.Services.Interfaces;

namespace Design.Patterns.Application.Strategy
{
    public class MainStrategy
    {
        public void BasicStrategy()
        {
            ITipoImposto iss = new IssService();
            ITipoImposto icms = new IcmsService();
            ITipoImposto iccc = new IcccService();
            Orcamento orcamento = new Orcamento(4000);

         

            CalculadoraService calculadora = new CalculadoraService();
            calculadora.RealizaCalculo(orcamento, iss);
            calculadora.RealizaCalculo(orcamento, icms);
            calculadora.RealizaCalculo(orcamento, iccc);
        }
    }
}
