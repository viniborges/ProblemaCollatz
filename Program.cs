using System;
using System.Linq;

namespace ProblemaCollatz
{
    class Program
    {
        static void Main()
        {
            const int elementos = 1000000;  //Constante com o número de elementos que vai percorrer.
            var sequencias = new int[elementos + 1]; //vetor para armazenar o numero de termos em cada elemento.

            //laço para percorrer cada elemento da constante, calcular o número de termos e jogar no vetor.
            for (int i = 1; i <= elementos; i++) 
            {
                sequencias[i] = ContSequencia(i); //aloca o resultado contador de termos no vetor.
                var porc = (100*i)/elementos; //calcula porcentagem
                Console.Write("\r{0}%", porc);
            }

            var maior = sequencias.Max(); //retorna o elemento do vetor com o maior termo.
            var index = Array.FindIndex(sequencias, rows=> rows == maior); //retorna o index do vetor de maior termo.
            Console.WriteLine();
            Console.WriteLine("O número que produz a maior sequência é o nº {0}, contendo {1} termos.", index, ContSequencia(index));
            Console.ReadKey();
        }
        
        //calcula o número de termos do elemento em questão
        private static int ContSequencia(int i)
        {
            int n = i;
            int contSequencia = 1;

            while (n > 1)
            {
                if (n%2 == 0)
                    n = n/2;
                else
                    n = (3*n) + 1;
                contSequencia++;
            }
            return contSequencia;
        }
    }
}
