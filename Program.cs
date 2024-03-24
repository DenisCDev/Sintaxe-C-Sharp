using System;

namespace SyntaxExplanation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis e Tipos de Dados:
            int idade = 25; // Declaração de uma variável do tipo inteiro
            double altura = 1.75; // Declaração de uma variável do tipo double
            string nome = "João"; // Declaração de uma variável do tipo string
            bool temCarro = true; // Declaração de uma variável do tipo booleano

            // Saída de Dados:
            Console.WriteLine("Olá, mundo!"); // Imprime no console

            // Comentários:
            // Este é um comentário de uma linha
            /* Este é um comentário
               de múltiplas linhas */

            // Operadores Aritméticos:
            int x = 5;
            int y = 3;
            int soma = x + y;
            int subtracao = x - y;
            int multiplicacao = x * y;
            int divisao = x / y;
            int modulo = x % y;

            // Operadores de Atribuição:
            int a = 10;
            a += 5; // a = a + 5;
            a -= 3; // a = a - 3;
            a *= 2; // a = a * 2;
            a /= 4; // a = a / 4;
            a %= 3; // a = a % 3;

            // Operadores de Comparação:
            bool maiorQue = (x > y);
            bool menorQue = (x < y);
            bool igual = (x == y);
            bool diferente = (x != y);
            bool maiorOuIgual = (x >= y);
            bool menorOuIgual = (x <= y);

            // Operadores Lógicos:
            bool condicao1 = true;
            bool condicao2 = false;
            bool resultadoE = condicao1 && condicao2;
            bool resultadoOU = condicao1 || condicao2;
            bool resultadoNao = !condicao1;

            // Estruturas de Controle - If/Else:
            int numero = 20;
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }

            // Switch Case:
            int dia = 4;
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }

            // Loops - While:
            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine("Contagem (While): " + contador);
                contador++;
            }

            // Loops - Do-While:
            contador = 0;
            do
            {
                Console.WriteLine("Contagem (Do-While): " + contador);
                contador++;
            } while (contador < 5);

            // Loops - For:
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Contagem (For): " + i);
            }

            // Loops - Foreach:
            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach (int num in numeros)
            {
                Console.WriteLine("Número: " + num);
            }

            // Arrays:
            int[] meuArray = new int[5]; // Declaração de um array de inteiros com 5 elementos
            meuArray[0] = 10;
            meuArray[1] = 20;
            meuArray[2] = 30;
            meuArray[3] = 40;
            meuArray[4] = 50;

            // Funções e Métodos:
            int resultado = Somar(3, 5);
            Console.WriteLine("Resultado da soma: " + resultado);

            // Classes e Objetos:
            Pessoa pessoa1 = new Pessoa("Maria", 30);
            pessoa1.Apresentar();

            Console.ReadLine();
        }

        // Definição de um método:
        static int Somar(int a, int b)
        {
            return a + b;
        }
    }

    // Definição de uma classe:
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor da classe:
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método da classe:
        public void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + Nome + " e tenho " + Idade + " anos.");
        }
    }
}
