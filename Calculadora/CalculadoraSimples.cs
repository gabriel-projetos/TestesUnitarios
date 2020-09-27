using System;

namespace Calculadora
{
    public class CalculadoraSimples
    {
        public int Adicionar(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool Multiplicar(int num1, int num2)
        {
            if((num1 * num2) > 20)
            {
                return true;
            }
            return false;
        }
    }
}
