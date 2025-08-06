using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.models
{
    /// <summary>
    /// Cria uma nova reserva
    /// </summary>
    public class Reserva
    {
        // construtores
        public Reserva()
        { 
            Hospedes = new List<Pessoa>();
        }
        public Reserva(int diasReservados)
        {
            this.diasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        // variáveis
        private int diasReservados;

        // getters e setters
        public int DiasReservados
        {
            get => diasReservados;
            set => diasReservados = value;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }

       

        /// <summary>
        /// Cadastra a suíte na reserva.
        /// </summary>
        /// <param name="suite">Objeto do tipo Suite a ser cadastrado.</param>
        public void CadastrarSuite(Suite suite)
        {
                Console.WriteLine($"Suite cadastrada com sucesso!");
                Suite = suite;
            
        }
     /// <summary>
        /// Cadastra os hóspedes na reserva, verificando se a quantidade não excede a capacidade da suíte.
        /// </summary>
        /// <param name="hospedes">Lista de hóspedes a serem cadastrados.</param>
        /// <exception cref="Exception">Lançada quando o número de hóspedes excede a capacidade da suíte.</exception>
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int totalHospedes = hospedes.Count;

            if (Suite.Capacidade >= totalHospedes + 1)
            {
                  Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Erro, a quantidade de hóspedes é superior ao suportado pela suíte");
              
            }
        }
        /// <summary>
        /// Retorna a quantidade de hóspedes informada na lista.
        /// </summary>
        /// <param name="hospedes">Lista de hóspedes.</param>
        /// <returns>Quantidade de hóspedes.</returns>
        public int ObterQuantidadeDeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        /// <summary>
        /// Calcula o valor total da diária da suíte, aplicando desconto para reservas de 10 dias ou mais.
        /// </summary>
        /// <param name="suite">Objeto do tipo Suite.</param>
        /// <returns>Valor total da diária.</returns>
        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria;
            decimal formula = Suite.ValorDiaria * DiasReservados;
            decimal desconto = formula * 10 / 100;
            if (DiasReservados >= 10)
            {
                valorDiaria = formula - desconto;
            }
            else
            {
                valorDiaria = formula;
            }
            return valorDiaria;
        }
    }
}