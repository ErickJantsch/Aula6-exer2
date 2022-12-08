using System;

namespace Aula6_exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2) Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência\n" +
                                    "de seus clientes.Escreva um algoritmo para ler o tipo de combustível abastecido\n" +
                                   " (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).Caso o usuário\n" +
                                   " informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código\n" +
                                   " (até que seja válido).O programa será encerrado quando o código informado for o\n" +
                                    "número 4.Deve ser escrito a mensagem: MUITO OBRIGADO e a quantidade de\n" +
                                     "clientes que abasteceram cada tipo de combustível,");

            Console.WriteLine();
            int Cod;
            int Alcool = 0;
            int Gasolina = 0;
            int Disel = 0;


            do
            {
                Console.WriteLine("Entre com o codigo do Conbustivel ou digite 4 para sair");


                Cod = int.Parse(Console.ReadLine());

                if (Cod == 1)
                {
                    Alcool++;
                }
                else if (Cod == 2)
                {
                    Gasolina++;
                }
                else if (Cod == 3)
                {
                    Disel++;
                }
                else if (Cod == 4)
                {
                    Console.WriteLine("Muito Obrigado " + Alcool + "\n Alcool:" + Gasolina + "\nGasolina:" + Disel + "\nDisel,");
                }
                else
                {
                    Console.WriteLine("Opcao invalida");
                }
            } while (Cod != 4);

        }
    }
}
