using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1: Aceitar apenas valores positivos");
            int v1;
            do
            {
                Console.Write("Digite um valor positivo: ");
                v1 = int.Parse(Console.ReadLine());
            } while (v1 <= 0);

            Console.WriteLine("Valor aceito: " + v1 + ".");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Questão 2: Segundo valor maior que o primeiro.");
            double n12, n22;

            Console.Write("Digite o primeiro valor: ");
            n12 = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o segundo valor: ");
                n22 = double.Parse(Console.ReadLine());

            } while (n22 <= n12);

            Console.WriteLine(n22 + " é maior que " + n12);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Questão 3: Aceitar apenas M ou F ");
            char sexo3;
            do
            {
                Console.Write("Informe o sexo (M/F): ");
                sexo3 = char.Parse(Console.ReadLine().ToUpper());

            } while (sexo3 != 'F' && sexo3 != 'M');
            Console.WriteLine("Sexo validado: " + sexo3);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Questão 4: Tabuada (5)");
            int numero = 5;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Questão 5: Tabuada de valor positivo");
            double v5;

            do
            {
                Console.Write("Informe um valor positivo: ");
                v5 = double.Parse(Console.ReadLine());

            } while (v5 <= 0);

            Console.WriteLine("\nTabuada do " + v5 + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(v5 + " x " + i + " = " + (v5 * i));
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Questão 6:");
            int valor1_6;
            int inicio2_6;
            int fim3_6;
            int contador4_6;

            do
            {
                Console.Write("Digite um valor positivo: ");
                valor1_6 = int.Parse(Console.ReadLine());

                if (valor1_6 <= 0)
                {
                    Console.WriteLine("Valor inválido!");
                }

            } while (valor1_6 <= 0);

            
            Console.Write("Digite o valor inicial (A): ");
            inicio2_6 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor final (B): ");
            fim3_6 = int.Parse(Console.ReadLine());

           
            while (fim3_6 <= inicio2_6)
            {
                Console.WriteLine("B deve ser maior que A!");

                Console.Write("Digite novamente o valor final (B): ");
                fim3_6 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nTabuada:");

            for (contador4_6 = fim3_6; contador4_6 >= inicio2_6; contador4_6--)
            {
                Console.WriteLine(valor1_6 + " x " + contador4_6 +
                                  " = " + (valor1_6 * contador4_6));
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Questão 7: Tabuada do 1 ao 20");              //q7
            int tabuada1_7;
            int contador2_7;

            for (tabuada1_7 = 1; tabuada1_7 <= 20; tabuada1_7++)
            {
                Console.Clear();

                Console.WriteLine("Tabuada do " + tabuada1_7 + "\n");

                for (contador2_7 = 1; contador2_7 <= 10; contador2_7++)
                {
                    Console.WriteLine(
                        tabuada1_7 + " x " +
                        contador2_7 + " = " +
                        (tabuada1_7 * contador2_7)
                    );
                }

                if (tabuada1_7 < 20)
                {
                    Console.WriteLine("\nPressione a tecla Enter para continuar");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("\nFim das tabuadas.");
            Console.ReadKey();
            Console.Clear();

                Console.WriteLine("Questão 8: ");
                int numero1_8;
                int soma2_8 = 0;

                for (numero1_8 = 1; numero1_8 <= 100; numero1_8++)
                {
                    soma2_8 += numero1_8;
                }

                Console.WriteLine("Soma = " + soma2_8);
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Questão 9: Série de Fibonacci ");
                int valor1_9 = 1;
                int valor2_9 = 1;
                int proximo3_9;
                int contador4_9;

                Console.Write(valor1_9 + ", " + valor2_9);

                for (contador4_9 = 3; contador4_9 <= 30; contador4_9++)
                {
                    proximo3_9 = valor1_9 + valor2_9;

                    Console.Write(", " + proximo3_9);

                    valor1_9 = valor2_9;
                    valor2_9 = proximo3_9;
                }
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Questão 10: ");
                double valor1_10;
                double maior2_10 = 0;
                double soma3_10 = 0;
                double media4_10;

                int contador5_10;

                for (contador5_10 = 1; contador5_10 <= 10; contador5_10++)
                {
                    do
                    {
                        Console.Write("Digite um valor positivo: ");
                        valor1_10 = double.Parse(Console.ReadLine());

                        if (valor1_10 <= 0)
                        {
                            Console.WriteLine("Erro! Digite apenas valores positivos.");
                        }

                    } while (valor1_10 <= 0);

                    soma3_10 += valor1_10;

                    if (contador5_10 == 1 || valor1_10 > maior2_10)
                    {
                        maior2_10 = valor1_10;
                    }
                }

                media4_10 = soma3_10 / 10;

                Console.WriteLine("\nMaior valor: " + maior2_10);
                Console.WriteLine("Soma dos valores: " + soma3_10);
                Console.WriteLine("Média aritmética: " + media4_10);
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Questão 11: Analisar valor de entrada");
                int quantidade1_11;
                int contador2_11;

                double valor3_11;
                double maior4_11 = 0;
                double menor5_11 = 0;
                double soma6_11 = 0;
                double media7_11;

                int positivos8_11 = 0;
                int negativos9_11 = 0;

                do
                {
                    Console.Write("Digite a quantidade de valores (maior que 0 e menor que 20): ");
                    quantidade1_11 = int.Parse(Console.ReadLine());

                    if (quantidade1_11 <= 0 || quantidade1_11 >= 20)
                    {
                        Console.WriteLine("Erro! Valor inválido.");
                    }

                } while (quantidade1_11 <= 0 || quantidade1_11 >= 20);

                for (contador2_11 = 1; contador2_11 <= quantidade1_11; contador2_11++)
                {
                    Console.Write("Digite um valor: ");
                    valor3_11 = double.Parse(Console.ReadLine());

                    soma6_11 += valor3_11;

                    if (contador2_11 == 1)
                    {
                        maior4_11 = valor3_11;
                        menor5_11 = valor3_11;
                    }

                    if (valor3_11 > maior4_11)
                    {
                        maior4_11 = valor3_11;
                    }

                    if (valor3_11 < menor5_11)
                    {
                        menor5_11 = valor3_11;
                    }

                    if (valor3_11 >= 0)
                    {
                        positivos8_11++;
                    }
                    else
                    {
                        negativos9_11++;
                    }
                }

                media7_11 = soma6_11 / quantidade1_11;

                Console.WriteLine("\nMaior valor: " + maior4_11);
                Console.WriteLine("Menor valor: " + menor5_11);
                Console.WriteLine("Soma: " + soma6_11);
                Console.WriteLine("Média: " + media7_11);

                Console.WriteLine("Porcentagem positivos: " +
                    ((double)positivos8_11 / quantidade1_11) * 100 + "%");

                Console.WriteLine("Porcentagem negativos: " +
                    ((double)negativos9_11 / quantidade1_11) * 100 + "%");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Questão 12: análise de valores de entrada");
                char resposta1_12;

                do
                {
                    int quantidade2_12;
                    int contador3_12;

                    double valor4_12;
                    double maior5_12 = 0;
                    double menor6_12 = 0;
                    double soma7_12 = 0;
                    double media8_12;

                    int positivos9_12 = 0;
                    int negativos10_12 = 0;

                    do
                    {
                        Console.Write("Digite a quantidade de valores (maior que 0 e menor que 20): ");
                        quantidade2_12 = int.Parse(Console.ReadLine());

                        if (quantidade2_12 <= 0 || quantidade2_12 >= 20)
                        {
                            Console.WriteLine("Erro! Valor inválido.");
                        }

                    } while (quantidade2_12 <= 0 || quantidade2_12 >= 20);

                    for (contador3_12 = 1; contador3_12 <= quantidade2_12; contador3_12++)
                    {
                        Console.Write("Digite um valor: ");
                        valor4_12 = double.Parse(Console.ReadLine());

                        soma7_12 += valor4_12;

                        if (contador3_12 == 1)
                        {
                            maior5_12 = valor4_12;
                            menor6_12 = valor4_12;
                        }

                        if (valor4_12 > maior5_12)
                        {
                            maior5_12 = valor4_12;
                        }

                        if (valor4_12 < menor6_12)
                        {
                            menor6_12 = valor4_12;
                        }

                        if (valor4_12 >= 0)
                        {
                            positivos9_12++;
                        }
                        else
                        {
                            negativos10_12++;
                        }
                    }

                    media8_12 = soma7_12 / quantidade2_12;

                    Console.WriteLine("\nMaior valor: " + maior5_12);
                    Console.WriteLine("Menor valor: " + menor6_12);
                    Console.WriteLine("Soma: " + soma7_12);
                    Console.WriteLine("Média: " + media8_12);

                    Console.WriteLine("Porcentagem positivos: " +
                        ((double)positivos9_12 / quantidade2_12) * 100 + "%");

                    Console.WriteLine("Porcentagem negativos: " +
                        ((double)negativos10_12 / quantidade2_12) * 100 + "%");

                    do
                    {
                        Console.Write("\nDeseja executar novamente? (S/N): ");
                        resposta1_12 = char.Parse(Console.ReadLine().ToUpper());

                        if (resposta1_12 != 'S' && resposta1_12 != 'N')
                        {
                            Console.WriteLine("Erro! Digite apenas S ou N.");
                        }

                    } while (resposta1_12 != 'S' && resposta1_12 != 'N');

                } while (resposta1_12 == 'S');
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Questão 13:");
                char resposta1_13;

            do
            {
                int valor2_13;
                int contador3_13;
                long fatorial4_13 = 1;


                do
                {
                    Console.Write("Digite um valor não negativo: ");
                    valor2_13 = int.Parse(Console.ReadLine());

                    if (valor2_13 < 0)
                    {
                        Console.WriteLine("Erro! Valor inválido.");
                    }

                } while (valor2_13 < 0);


                for (contador3_13 = valor2_13; contador3_13 >= 1; contador3_13--)
                {
                    fatorial4_13 = fatorial4_13 * contador3_13;
                }

                Console.WriteLine("Fatorial = " + fatorial4_13);


                do
                {
                    Console.Write("Deseja novo cálculo? (S/N): ");
                    resposta1_13 = char.Parse(Console.ReadLine().ToUpper());

                    if (resposta1_13 != 'S' && resposta1_13 != 'N')
                    {
                        Console.WriteLine("Resposta inválida!");
                    }

                } while (resposta1_13 != 'S' && resposta1_13 != 'N');

            } while (resposta1_13 == 'S');
            Console.ReadKey();
            Console.Clear();

                Console.WriteLine("Fim da atividade.");
            }
        }
    }
