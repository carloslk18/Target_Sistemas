using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Models{
public class Reserva{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados){
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes){

        if (hospedes.Count <= Suite.Capacidade){
            Hospedes = hospedes;
        }
        else{
            throw new Exception("A quantidade de hóspedes não pode ser maior que a quantidade disponível na suite.");
        }
    }

    public void CadastrarSuite(Suite suite){
        Suite = suite;
    }

    public int ObterQuantidadeHospedes(){
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria(){
        
        var valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10){
            valor *= 0.90M;
        }

        return valor;
    }
}
}