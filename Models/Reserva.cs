using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelariaDio.Models;

namespace HotelariaDio.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes{ get; set; }
        public Suite Suite { get;  set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            
            if(hospedes.Count <= 3)
            {
                  Hospedes = hospedes;
            }
            else
            {
                 throw new ArgumentException ("Numero de pessoa maior que o permitido!", nameof(hospedes));
            }
        }
        public int ObterQuantidadeHospede(){
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            decimal result = 0;

           if(DiasReservados >= 10)
           {
               valor = DiasReservados * Suite.ValorDiaria;
                result = valor * 10 / 100;
           }
           else 
           { 
               valor = DiasReservados * Suite.ValorDiaria;
           }
           return valor - result;

        }
    }
}