﻿
/*
Sucessor Par

Para se preparar para os outros problemas, vamos fazer um teste. Dado um número X, retorne o menor número 
par maior do que X.

Entrada
Uma linha contendo um número 0 < X < 107.

Saída
Uma linha contendo a resposta do problema.
*/

using System;

namespace Desafio6
{
    class DIO
    {
        static void Main(String[] args)
        {
            Console.Write("Digite um Número: ");
            int x = int.Parse(Console.ReadLine());
            int y;
            if(x % 2 == 0)
            {
                y = x + 2;
            }
            else
            {
                y = x + 1;
            }
            Console.WriteLine(y);
        }
    }
}