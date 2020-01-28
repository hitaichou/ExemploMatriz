using System;

namespace ExemploMatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            //O [,] indica um arranjo bidimencional, ou seja, com linhas e colunas
            /*
                Esta instanciação cria na memória a matriz com as posições: 0,0; 0,1; 0,2; 1,0; 1,1; 1,2 
             */
            double[,] mat = new double[2, 3]; 
            
            
            Console.WriteLine(mat.Length); //mostra a qtd de elementos tem na matriz

            Console.WriteLine(mat.Rank); //mostra a qtd de linhas

            Console.WriteLine(mat.GetLength(0)); //o GetLength precisa de um parâmetro, o 0 pega a primeira dimenção, no caso, qtas linhas há na matriz

            Console.WriteLine(mat.GetLength(1)); //Passando 1 como parâmetro, pega a segunda dimenção no qual mostra a qtd de colunas

        }
    }
}
