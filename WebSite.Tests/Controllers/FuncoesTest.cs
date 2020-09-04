using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using Domain;
using System.Linq;

namespace WebSite.Tests.Controllers
{
    [TestClass]
    public class FuncoesTest
    {
        [TestMethod]
        public void TestaFibonacci()
        {
            Funcoes.retornaFibonacci();
        }

        [TestMethod]
        public void TestaNumeros()
        {
            Funcoes.imprimeNumeros();
        }

        [TestMethod]
        public void TestaArvore()
        {
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

            Funcoes.caminho_arvore(root, 9);
        }


        [TestMethod]
        public void TestaPalavraTriangulo()
        {
            Funcoes.palavraTriangulo("SKY");
        }

        [TestMethod]
        public void TestaAcumular()
        {

            int[] numeros = { 10, 20, 30, 40 };
            Funcoes.Acumular((s, n) => (s >= n) ? n : s, Int32.MaxValue, numeros.ToList());
        }


        [TestMethod]
        public void TestaSomaQuadrado()
        {

            int[] numeros = { 1, 2, 3, 4,5 };
            Funcoes.somaDeQuadrados(numeros.ToList());
        }
    }
}
