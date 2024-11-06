//Questao 03
//Para instalar o pacote Newtonsoft > Install-Package Newtonsoft.Json

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

class Q03{
    static void Main(){
        string caminhoArquivo = "outputQ03.json";

        string json = File.ReadAllText(caminhoArquivo);
        
        var faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        var fatValidos = faturamentos.Where(f => f.ValorFat > 0).ToList();

        var menorFat = fatValidos.Min(f => f.ValorFat);
        
        var maiorFat = fatValidos.Max(f => f.ValorFat);

        var mediaFat = fatValidos.Average(f => f.ValorFat);

        var diasAcimaDaMedia = fatValidos.Count(f => f.ValorFat > mediaFat);

        Console.WriteLine("Menor faturamento: {0}",menorFat);
        Console.WriteLine("Maior faturamento: {0}",maiorFat);
        Console.WriteLine("Número de dias com faturamento superior à média: {0}",diasAcimaDaMedia);
    }
}

class Faturamento{
    public int Dia { get; set; }
    public decimal ValorFat { get; set; }
}
