﻿using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Models;

namespace Hotel{
public class Program{

    public static void Main(){

        Console.OutputEncoding = Encoding.UTF8;

        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa("Hóspede 1");
        Pessoa p2 = new Pessoa("Hóspede 2");

        hospedes.Add(p1);
        hospedes.Add(p2);

        // Cria a suíte
        Suite suite = new Suite( "Premium",  2,  30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new Reserva( 10);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

    }
}
}
