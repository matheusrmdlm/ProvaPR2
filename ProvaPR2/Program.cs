using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Menu");
            Console.WriteLine("exercício 1");
            Console.WriteLine("exercício 2");
            Console.WriteLine("exercício 3");
            Console.WriteLine("exercício 4");
            Console.WriteLine("exercício 5");
            Console.WriteLine("exercício 6");
            Console.WriteLine("exercício 7");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:
                    Console.WriteLine("digite um número inteiro(número sem vígula)");
                    int nuber = int.Parse(Console.ReadLine());
                    if (nuber >= 0)
                    {
                        Console.WriteLine(nuber);
                    }
                    else;
                    {
                        int nube = nuber * (-1);
                        Console.WriteLine(nube);

                        break;
                    }
                    break;

                case 2:
                    Console.WriteLine("digite seu número");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
                    {
                        Console.WriteLine("seu número é divisivel por 3,5 e 7");
                    }
                    else
                    {
                        if (num % 3 == 0 && num % 5 == 0)
                        {
                            Console.WriteLine("ele é divisivel por 3 e 5");
                        }
                        else if (num % 7 == 0 && num % 5 == 0)
                        {
                            Console.WriteLine("ele é divisivel por 5 e 7");
                        }
                        else if (num % 7 == 0 && num % 3 == 0)
                        {
                            Console.WriteLine("ele é divisivel por 3 e 7");
                        }
                        else if (num % 3 == 0)
                        {
                            Console.WriteLine("ele é divisilvel por 3");
                        }
                        else if (num % 5 == 0)
                        {
                            Console.WriteLine("ele é divisilvel por 5");
                        }
                        else
                        {
                            Console.WriteLine("ele não é divisilvel por 3 5 ou 7");
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("digite o primero número");
                    int nu1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite o segundo número");
                    int nu2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite o terceiro número");
                    int nu3 = int.Parse(Console.ReadLine());

                    if (nu1 > nu2 && nu1 > nu3)
                    {
                        Console.WriteLine("maior número é : " + nu1);
                    }
                    else
                    {
                        if (nu1 < nu2 && nu1 < nu3)
                        {
                            Console.WriteLine("maior número é : " + nu2);
                        }
                        else if (nu1 < nu2 && nu1 < nu3)
                        {
                            Console.WriteLine("maior número é : " + nu3);
                        }
                        else
                            Console.WriteLine("os números são todos igua");
                    }

                    break;

                case 4:
                    Console.WriteLine("Digite o número referente ao dia da semana(do 1 ao 7)");
                    int sem = int.Parse(Console.ReadLine());
                    switch (sem)
                    {
                        case 1:
                            Console.WriteLine("Dia escolhido é domingo, nada de escola \n gosto de jogar video game e dormir");
                            break;

                        case 2:
                            Console.WriteLine("Dia escolhido é segunda-feira, escola\n hoje tem português,matematica e filosofia");
                            break;
                        case 3:
                            Console.WriteLine("Dia escolhido é terça-feira, escola\n hoje tem quimica,inglês e historia");
                            break;
                        case 4:
                            Console.WriteLine("Dia escolhido é quarta-feira, escola\n hoje tem biologia,portugues e programação");
                            break;
                        case 5:
                            Console.WriteLine("Dia escolhido é quinta-feira, escola\n hoje tem redes,fisica e sociologia");
                            break;
                        case 6:
                            Console.WriteLine("Dia escolhido é segunda-feira, escola\n hoje tem banco de dados,matematica e geografia");
                            break;
                        case 7:
                            Console.WriteLine("Dia escolhido é sabádo, nada de escola \n gosto de jogar video game e dormir");
                            break;
                        default:
                            Console.WriteLine("Número informado inválido");
                            break;

                    }

                    break;

                case 5:
                    int maior = int.MinValue, menor = int.MaxValue;
                    int num = 1;

                    Console.Write("Digite um número inteiro (ou zero para sair): ");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 1; num != 0; i++)
                    {
                        if (num > maior)
                        {
                            maior = num;
                        }
                        if (num < menor)
                        {
                            menor = num;
                        }

                        Console.Write("Digite um número inteiro (ou zero para sair): ");
                        num = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Maior número: {0}", maior);
                    Console.WriteLine("Menor número: {0}", menor);
s
                    break;

                case 6:
                    int nume, sum = 0;

                    Console.Write("Digite um número inteiro: ");
                    nume = int.Parse(Console.ReadLine());

                    for (int i = 1; i < nume; i++)
                    {
                        if (nume % i == 0)
                        {
                            sum += i;
                        }
                    }

                    if (sum == nume)
                    {
                        Console.WriteLine(" é um número perfeito", +nume);
                    }
                    else
                    {
                        Console.WriteLine("não é um número perfeito", +nume);
                    }

                    break;

                case 7:
                    int ll = 0, lo = 1;
                    for (int op = 0; ; op++)
                    {
                        Console.WriteLine("digite um numero");
                        int par = int.Parse(Console.ReadLine());
                        if (op % 2 == 0)
                        {
                            ll += par;
                            lo += 1;
                        }
                        else if (par == 0)
                            break;

                    }
                    int ka = ll / (lo - 1);
                    Console.WriteLine("A mediá aritmetima deu " + ka);
                    break;
                default:
                    Console.WriteLine("número invalido");
                    break;
            }
        }
    }
}