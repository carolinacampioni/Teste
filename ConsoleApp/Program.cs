using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Domain;


namespace ConsoleApp
{
    class Program
    {
        static string opcao;
        static void Main(string[] args)
        {
             opcao = montaMenu();
             escolheOpcao();

            

        }
        static string montaMenu() {
            Console.Write("Escolha uma opção:\n " +
                "1 - Imprime números de 1 a 100" +
                "\n2 - Soma de quadrados" +
                "\n3 - Fibonacci" +
                "\n4 - Caminho de arvore" +
                "\n5 - Acumular" +
                "\n6 - Palavra Triângulo\nOpção:");
            return Console.ReadLine();
        }

        static void escolheOpcao() {
            if (opcao.Equals("1"))
            {

                Console.Write("Lista de números de 1 a 100:\n ");
                Funcoes.imprimeNumeros();
                Console.ReadLine();
                opcao = montaMenu();
                escolheOpcao();
            }
            else if (opcao.Equals("2"))
            {
                List<int> numeros;
                Console.Write("Digite uma lista de números inteiros separados por virgula:");
                string input = Console.ReadLine();
                numeros = input.Split(',').Select(Int32.Parse).ToList();
                long soma = Funcoes.somaDeQuadrados(numeros);
                Console.WriteLine("A soma dos quadrados é: {0}", soma);
                Console.ReadLine();
                opcao = montaMenu();
                escolheOpcao();
            }
            else if (opcao.Equals("3"))
            {
                var fibonacci = Funcoes.retornaFibonacci();
                Console.WriteLine("Fibonacci: {0}", fibonacci);
                Console.ReadLine();
                opcao = montaMenu();
                escolheOpcao();
            }
            else if (opcao.Equals("4"))
            {

                //Cria arvore
                Arvore root = new Arvore(1);
                root.left = new Arvore(4);
                root.right = new Arvore(7);
                root.left.left = new Arvore(10);
                root.left.left.left = new Arvore(8);
                root.left.right = new Arvore(2);
                root.left.right.left = new Arvore(12);
                root.left.right.left.right = new Arvore(13);
                root.left.right.left.right.left = new Arvore(9);
                root.right.left = new Arvore(3);
                root.right.right = new Arvore(11);
                root.right.right.left = new Arvore(6);
                root.right.right.right = new Arvore(5);
               

                Console.WriteLine("Digite um nó:");
                var n = Console.ReadLine();
                Int32.TryParse(n, out int node);
                Funcoes.caminho_arvore(root, node);
                Console.ReadLine();
                opcao = montaMenu();
                escolheOpcao();
            }
            else if (opcao.Equals("5"))
            {

                Console.WriteLine("Digite uma sequencia de numeros separados por virgula:");
                var sequencia = Console.ReadLine();
                int[] numeros = Array.ConvertAll(sequencia.Split(','), int.Parse);
                var result = Funcoes.Acumular((s, n) => (s >= n) ? n : s, Int32.MaxValue, numeros.ToList());
                Console.WriteLine(result);
                Console.ReadLine();
                opcao = montaMenu();
                escolheOpcao();
            }
            else if (opcao.Equals("6"))
            {

                Console.WriteLine("Digite uma palavra:");
                var palavra = Console.ReadLine();
                var result = Funcoes.palavraTriangulo(palavra);
                Console.WriteLine(result);
                Console.ReadLine();
                opcao = montaMenu();
                escolheOpcao();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                opcao = montaMenu();
                escolheOpcao();
            }
        }
    }
}
