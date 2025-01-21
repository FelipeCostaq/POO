using System;

namespace poo004
{
    internal class Pessoa
    {
        public double peso;
        public double altura;

        public double CalculoImc()
        {
            double imc = peso / (altura * altura);
            return Math.Round(imc, 2);
            
        }

        public void Mensagem()
        {
            if (CalculoImc() <= 18.5)
            {
                Console.WriteLine($"Você está com IMC {CalculoImc()}. Você esta abaixo do peso");
            }
            else if (CalculoImc() >= 18.6 && CalculoImc() <= 25)
            {
                Console.WriteLine($"Você está com IMC {CalculoImc()}. Você esta com peso normal");
            }
            else if (CalculoImc() >= 26 && CalculoImc() <= 30)
            {
                Console.WriteLine($"Você está com IMC {CalculoImc()}. Você acima do peso");
            }
            else if (CalculoImc() >= 31 && CalculoImc() <= 35)
            {
                Console.WriteLine($"Você está com IMC {CalculoImc()}. Você com obesidade 1");
            }
            else if (CalculoImc() >= 36 && CalculoImc() <= 40)
            {
                Console.WriteLine($"Você está com IMC {CalculoImc()}. Você com obesidade 2");
            }
            else
            {
                Console.WriteLine($"Você está com IMC {CalculoImc()}. Você com obesidade 3");
            }
        }

    }
}
