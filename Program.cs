using System;
using System.Collections.Generic;

namespace Exercicio_individual_Tema_Exemplo_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //Declaração de uma lista de strings
            list.Add("Fábio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("Andre"); //Adicionando elementos na lista
            list.Insert(2, "Lucas"); //Inseri Lucas na lista
            foreach (string obj in list) //Loop para passar em todos os elementos
            {
                Console.WriteLine(obj); //Mostra cada elemento cada vez que passa no loop
            }
            Console.WriteLine("Quantos elementos têm a Lista: " + list.Count); //Mostra quantos elementos tem na lista
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1); //Mostra o primeiro elemento que começa com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último elemento que começa com a letra A: " + s2); //Mostra o último elemento que começa com a letra A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição de 'A': " + pos1); //Mostra a primeira posição de A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última Posição de 'A': " + pos2);
            List<string> list2 = list.FindAll(x => x.Length == 5); //Procura por todos elementos com tamanho de 5 caracteres
            Console.WriteLine("---------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Andre"); //Remove Andre da lista
            Console.WriteLine("===========================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'W'); // Remover determinado elemento da lista, no caso com W, logo Wilson
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAt(3); //Remove o elemento 3 da lista
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveRange(1, 2); //Remove elementos de determinada posição da lista
            Console.WriteLine("___________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}