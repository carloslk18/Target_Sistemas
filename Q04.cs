//Questao 04
using System;

class Q04{
    static void Main(){
        decimal sp = 67836.43m;
        decimal rj = 36678.66m;
        decimal mg = 29229.88m;
        decimal es = 27165.48m;
        decimal outros = 19849.53m;

        decimal totalFaturamento = sp + rj + mg + es + outros;

        decimal percSP = (sp / totalFaturamento)*100;
        decimal percRJ = (rj / totalFaturamento)*100;
        decimal percMG = (mg / totalFaturamento)*100;
        decimal percES = (es / totalFaturamento)*100;
        decimal percOutros = (outros / totalFaturamento)*100;

        Console.WriteLine("Percentual de SP: {0:F2}%",percSP);
        Console.WriteLine("Percentual de RJ: {0:F2}%",percRJ);
        Console.WriteLine("Percentual de MG: {0:F2}%",percMG);
        Console.WriteLine("Percentual de ES: {0:F2}%",percES);
        Console.WriteLine("Percentual de Outros: {0:F2}%",percOutros);
    }
}
