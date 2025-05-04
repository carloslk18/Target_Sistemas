//Questao 05
using System;

class Q05{
    static void Main(){
        Console.WriteLine("Informe a string: ");
        string input = Console.ReadLine();

        char[] caract = input.ToCharArray();

        int inicio = 0;
        int fim = caract.Length -1;

        while (inicio < fim){
            char temp = caract[inicio];
            caract[inicio] = caract[fim];
            caract[fim] = temp;

            inicio++;
            fim--;
        }

        string res = new string(caract);

        Console.WriteLine("String invertida: {0}", res);
    }
}
 