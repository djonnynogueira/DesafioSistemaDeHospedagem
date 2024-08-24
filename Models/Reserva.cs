using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSistemaDeHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*    
            if (Suite != null && hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade da súite é insuficientes para o número de hóspedes");
            }

            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // *IMPLEMENTE AQUI*
        
    }

        public void CadastrarSuites(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
            {
                valor *= 0.9M;
            }

            return (valor);
        }

}
}