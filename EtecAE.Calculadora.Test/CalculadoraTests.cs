using EtecAE.Calculadora.Lib;
using System;
using System.Linq;
using Xunit;

namespace EtecAE.Calculadora.Test
{
    public class CalculadoraTests
    {
        [Fact]
        public void RetornaSomaDado2ValoresInteiros()
        {
            var calculo = new Calculador();

            int valor1 = 1;
            int valor2 = 2;

            var resultado = calculo.Somar(valor1, valor2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]

        public void TheoryRetornaSomaDado2Valores(int v1, int v2, int esperado)
        {
            var calculo = new Calculador();

            var resultado = calculo.Somar(v1, v2);

            Assert.Equal(esperado, resultado);
        }

        //Subtração

        [Fact]
        public void RetornaSubtDado2ValoresInteiros()
        {
            var calculo = new Calculador();

            int valor1 = 10;
            int valor2 = 2;

            var resultado = calculo.Subtrair(valor1, valor2);

            Assert.Equal(8, resultado);
        }

        [Theory]
        [InlineData(10, 6, 4)]
        [InlineData(6, 4, 2)]
        [InlineData(20, 20, 0)]

        public void TheoryRetornaSubtDado2Valores(int v1, int v2, int esperado)
        {
            var calculo = new Calculador();

            var resultado = calculo.Subtrair(v1, v2);

            Assert.Equal(esperado, resultado);
        }


        //Dividir

        [Fact]
        public void RetornaDivDado2ValoresInteiros()
        {
            var calculo = new Calculador();

            int valor1 = 20;
            int valor2 = 2;

            var resultado = calculo.Dividir(valor1, valor2);

            Assert.Equal(10, resultado);
        }

        [Theory]
        [InlineData(15, 5, 3)]
        [InlineData(-27, 3, -9)]
        [InlineData(3, 3, 1)]

        public void TheoryRetornaDivDado2Valores(int v1, int v2, int esperado)
        {
            var calculo = new Calculador();

            var resultado = calculo.Dividir(v1, v2);

            Assert.Equal(esperado, resultado);
        }


        //Multiplicar

        [Fact]
        public void RetornaMultDado2ValoresInteiros()
        {
            var calculo = new Calculador();

            int valor1 = 5;
            int valor2 = 5;

            var resultado = calculo.Multiplicar(valor1, valor2);

            Assert.Equal(25, resultado);
        }

        [Theory]
        [InlineData(9, 9, 81)]
        [InlineData(-7, 5, -35)]
        [InlineData(3, 3, 9)]

        public void TheoryRetornaMultDado2Valores(int v1, int v2, int esperado)
        {
            var calculo = new Calculador();

            var resultado = calculo.Multiplicar(v1, v2);

            Assert.Equal(esperado, resultado);
        }


    



    }
}
