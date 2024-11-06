using System;
//Questão 01

class Q01{
    static void Main(){
        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE){
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("O valor de SOMA é: " + SOMA);
    }
}