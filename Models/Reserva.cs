using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSistemaDeHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes = new List<Pessoa>();

        public Suite suite;
        public int DiasReservados { get; set; }

    }
}