using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("    menu");
        Console.WriteLine("Exercicio 1");
        Console.WriteLine("Exercicio 2");
        Console.WriteLine("Exercicio 3");
        Console.WriteLine("Exercicio 4");
        Console.WriteLine("Exercicio 5");
        Console.WriteLine("Exercicio 6");
        Console.WriteLine("Exercicio 7");
        int exec = int.Parse(Console.ReadLine());

        switch (exec)
        {
            case 1:
                
                    Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }
                    break;

            case 2;

                for (int i = 2; i <= num; i += 2)
                {
                    Console.Write(i + " ");
                

                break;

                case 3:

                Console.WriteLine("digite um valor\n");
                int numm = int.Parse(Console.ReadLine());
                for (int i = 1000; i >= numm; i--)
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                break;

            case 4:
                int nue = 0;
                for (int i = 0; i <= 200; i += nue)
                {
                    if (nue < 0)
                    {
                        Console.WriteLine("Número inválido");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("entre com um número para somar\n");
                        Console.WriteLine("número atual = " + i);
                        nue = int.Parse(Console.ReadLine());
                    }
                }
                break;

            case 5:
                Console.WriteLine("entre com um número\n");
                int ni = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10000; i++)
                    if (ni % i == 0)
                        Console.WriteLine("ele é divisivel por : " + i);
                break;

            case 6:
                int no = int.MaxValue;
                int ny = int.MinValue;

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Digite o {0}º número: ", i);
                    int numero = int.Parse(Console.ReadLine());

                    if (numero < no)
                    {
                        no = numero;
                    }

                    if (numero > ny)
                    {
                        ny = numero;
                    }
                }
                Console.WriteLine("\nO menor número digitado foi: {0}", no);
                Console.WriteLine("O maior número digitado foi: {0}", ny);
                break;

            case 7:
                int numj, somaPar = 0, somaImpar = 0;

                Console.Write("Digite um número: ");
                numj = Convert.ToInt32(Console.ReadLine());

                for (; numj != 0;)
                {
                    if (numj % 2 == 0)
                    {
                        somaPar += numj;
                    }
                    else
                    {
                        somaImpar += numj;
                    }

                    Console.Write("Digite um número: ");
                    numj = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("A soma dos números pares é: " + somaPar);
                Console.WriteLine("A soma dos números ímpares é: " + somaImpar);
                break;
        }
    }
}
}

        }
}
