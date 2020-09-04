using Domain;
using System;
using System.Collections.Generic;

namespace Service
{
    public class Funcoes
    {
      

        public static void imprimeNumeros()
        {
            for (int i = 1; i < 101; i++)
            {

                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.Write(i + " <Nome><Sobrenome>,\n");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(i + " <Nome>,\n");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(i + " <SobreNome>,\n");
                }
                else
                {
                    Console.Write(i + ",\n");
                    i = i + 0;
                }

            }
        }

        public static long somaDeQuadrados(List<int> inteiros)
        {

            //int.TryParse(input, out num);
            long soma = 0;
            foreach (int numero in inteiros)
            {
                long result = Squares(numero);
                soma = +result;
            }
            return soma;
            //Console.WriteLine("A soma dos quadrados é: {0}", soma);
        }

        static long Squares(long value)
        {
            long totalSum;

            if (value > 0)
            {
                totalSum = Squares(value - 1) + (value * value);

            }
            else if (value == 1)
            {
                totalSum = 1;
            }
            else
            {
                totalSum = 0;
            }


            return totalSum;

        }

        public static long retornaFibonacci()
        {
            int l1 = 1;
            int l2 = 1;
            int current = l1 + l2;
            while (current.ToString().Length < 5)
            {
                l2 = l1;
                l1 = current;
                current = l1 + l2;
            }
            return current;
        }

        public static Boolean hasPath(Arvore root,
                            List<int> arr, int x)
        {
            // if root is NULL  
            // there is no path  
            if (root == null)
                return false;

            // push the node's value in 'arr'  
            arr.Add(root.id);

            // if it is the required node  
            // return true  
            if (root.id == x)
                return true;

            // else check whether the required node lies  
            // in the left subtree or right subtree of  
            // the current node  
            if (hasPath(root.left, arr, x) ||
                hasPath(root.right, arr, x))
                return true;

            // required node does not lie either in the  
            // left or right subtree of the current node  
            // Thus, remove current node's value from  
            // 'arr'and then return false      
            arr.RemoveAt(arr.Count - 1);
            return false;
        }

        public static void caminho_arvore(Arvore root, int x)
        {
            // List to store the path  
            List<int> arr = new List<int>();

            // if required node 'x' is present  
            // then print the path  
            if (hasPath(root, arr, x))
            {
                for (int i = 0; i < arr.Count - 1; i++)
                    Console.Write(arr[i] + "->");
                Console.Write(arr[arr.Count - 1]);
            }

            // 'x' is not present in the binary tree  
            else
                Console.Write("No Path");
        }

        static bool isTriangular(int num)
        {
            // Base case 
            if (num < 0)
                return false;

            // A Triangular number must be 
            // sum of first n natural numbers 
            int sum = 0;

            for (int n = 1; sum <= num; n++)
            {
                sum = sum + n;
                if (sum == num)
                    return true;
            }

            return false;
        }

        static int numeroTriangular(int N)
        {
            if (isTriangular(N))
            {
                int A = (int)(Math.Sqrt(2 * N + 0.25) - 0.5);
                return A;
            }
            else
            {

                return -1;
            }

        }

        public static int palavraTriangulo(string palavra)
        {
            int soma = 0;
            foreach (char c in palavra)
            {
                int index = ((int)char.ToUpper(c)) - 64;
                soma += index;
            }

            return numeroTriangular(soma);


        }
   
        public delegate T Combiner<T>(T val1, T val2);

        public static T Acumular<T>(Combiner<T> function,T nullValue, List<T> list)
        {
            if (list.Count == 0)
            {
                return nullValue;
            }
            var primeiro = list[0];
            list.RemoveAt(0);
            return function(primeiro,Acumular(function, nullValue,list)); ;

        }






    }
}


