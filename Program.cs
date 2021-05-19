using System;
using System.Collections.Generic;

namespace CelularFuncionalidade
{
    class Program
    {
        static List<Celulares> cLista = new List<Celulares>();
        static Celulares celular1 = new Celulares();
        
        static Celulares celular2 = new Celulares();
        static Celulares celular3 = new Celulares();

        static int cEscolhido;
        static int opcCelular;

        static int acao;
        static void Main(string[] args)
        {
            celular1.modelo = "Iphone 11";
            celular1.cor = "Preto";
            celular1.tamanho = 6.1f;
            celular1.ligado = false;

            celular2.modelo = "Moto G9";
            celular2.cor = "Branco";
            celular2.tamanho = 6.5f;
            celular2.ligado = false;

            celular3.modelo = "Redmi Note 10";
            celular3.cor = "Cinza";
            celular3.tamanho = 6.4f;
            celular1.ligado = false;

            cLista.Add(celular1);
            cLista.Add(celular2);
            cLista.Add(celular3);

            //Começo
            cEscolhido = EscolheCelular();
            bool celularRodando = true;
            while (celularRodando)
            {
                bool ligado = cLista[cEscolhido-1].ligado;

                acao = EscolherAcao();
                if (!ligado && acao != 1)
                {
                    Console.WriteLine("\nÉ necessario ligar o celular primeiro.\n");
                } 
                else if (acao == 1) 
                {
                    Ligar();
                }
                else if (acao == 2) 
                {
                    FazerLigacao();
                }
                else if (acao == 3) 
                {
                    MandarMensagem();
                }
                else if (acao == 0) 
                {
                    Console.WriteLine("Desligando...");
                    celularRodando = false;
                }
            }

        }
        static int EscolheCelular() {
            Console.WriteLine("Qual celular você quer usar?");
            int c = 1;
            foreach (var celular in cLista)
            {
                Console.WriteLine($"{celular.modelo} [{c}]");
                c++;
            }
            Console.Write("-> ");
            opcCelular = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{cLista[opcCelular-1].modelo}"); //Printa o modelo do celular
            return opcCelular;
        }

        static int EscolherAcao() {
            Console.WriteLine("O que você deseja fazer?\n");
            Console.WriteLine("Ligar [1]\nFazer ligação [2]\nMandar mensagem [3]\nDesligar [0]");
            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        static void Ligar() {
            string modelo = cLista[opcCelular-1].modelo;
            if (cLista[opcCelular-1].ligado == false) {
                cLista[opcCelular-1].Ligar();
                Console.WriteLine($"\nO {modelo} está ligado");
            } else {
                Console.WriteLine($"\nO {modelo} já está ligado");
            }
        }

        static void FazerLigacao() {
            Console.WriteLine("Digite o número que deseja ligar: ");
            string numero = Console.ReadLine();
            Console.WriteLine($"\nLigando para {numero}...\n");
            Console.WriteLine(cLista[cEscolhido-1].FazerLigacao());
        }

        static void MandarMensagem() {
            Console.WriteLine("Para quem você quer enviar a mensagem?");
            string receptor = Console.ReadLine();
            Console.WriteLine("Digite a mensagem: ");
            string mensagem = Console.ReadLine();
            Console.WriteLine($@"
                {receptor}
                
Você'{mensagem}'
            ");
            Console.WriteLine(cLista[cEscolhido-1].EnviarMensagem());
        }
    }
}
