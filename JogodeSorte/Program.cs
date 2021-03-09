using System;

namespace JogodeSorte
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinheiro = 500;

            while (dinheiro > 0)
            {


                Console.WriteLine("BEM VINDO AO LUCKY GAME");
                Console.WriteLine("----------------------");
                Console.WriteLine("Você possui R$ " + dinheiro);
                Console.WriteLine("----------------------");



                Console.WriteLine("Escolha um número entre 0 e 20");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quanto deseja apostar nesse número?");
                double dinheiro1 = Convert.ToDouble(Console.ReadLine());

                if (dinheiro1 > dinheiro)
                {
                    Console.WriteLine("Saldo Insuficiente!!!");
                }

                Random r = new Random();
                int pc = r.Next(0, 20);

                Random n = new Random();
                int nd = n.Next(0, 30);

                double diffJ = num - nd;
                double diffC = pc - nd;

                if (diffJ < 0)
                {
                    diffJ = diffJ * -1;
                }

                if (diffC < 0)
                {
                    diffC = diffC * -1;
                }

                if (diffC > diffJ)
                {

                    Console.WriteLine("----------------------");
                    Console.WriteLine("O Computador escolheu: " + pc);
                    Console.WriteLine("----------------------");
                    Console.WriteLine("O Número Decisivo foi: " + nd);
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Parabéns! Você venceu!");

                    double aposta = dinheiro - dinheiro1;

                    double lucro = dinheiro1 * 0.25;

                    double soma = dinheiro1 + lucro;
                    dinheiro = dinheiro + soma;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("-");
                    Console.WriteLine("-");

                }
                else
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("O Computador escolheu: " + pc);
                    Console.WriteLine("----------------------");
                    Console.WriteLine("O Número Decisivo foi: " + nd);
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Game Over!! Você perdeu!");

                    double aposta = dinheiro - dinheiro1;




                    dinheiro = dinheiro - dinheiro1;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("-");
                    Console.WriteLine("-");


                }


            }
        }
    }
}
