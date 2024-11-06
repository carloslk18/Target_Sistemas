using System;
//Questão 02
class Q02{
    static void Main(){
    
        Console.WriteLine("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (pertFibonacci(numero)){
            Console.WriteLine("O número {0} pertence a sequência de Fibonacci.", numero);
        }
        else{
            Console.WriteLine("O número {0} NÃO pertence a sequência de Fibonacci.", numero);
        }
    }

    static bool pertFibonacci(int num){
        int a = 0, b = 1;

        if (num == a || num == b) return true;

        while (b < num){
            int temp = b;
            b = a + b;
            a = temp;
        }

        return b == num;
    }
}
