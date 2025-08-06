using System;

namespace trilha_net_explorando_desafio.models
{
    /// <summary>
    /// Representa uma suíte disponível para reserva.
    /// </summary>
    public class Suite
    {
        /// <summary>
        /// Inicializa uma nova instância da classe Suite.
        /// </summary>
        public Suite() { }

        /// <summary>
        /// Inicializa uma nova instância da classe Suite com parâmetros.
        /// </summary>
        /// <param name="tipoSuite">Tipo da suíte.</param>
        /// <param name="capacidade">Capacidade máxima de hóspedes.</param>
        /// <param name="valorDiaria">Valor da diária.</param>
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            this.tipoSuite = tipoSuite;
            this.capacidade = capacidade;
            this.valorDiaria = valorDiaria;
        }

        // variáveis privadas
        private string tipoSuite;
        private int capacidade;
        private decimal valorDiaria;

        /// <summary>
        /// Tipo da suíte.
        /// </summary>
        public string TipoSuite
        {
            get => tipoSuite;
            set => tipoSuite = value;
        }

        /// <summary>
        /// Capacidade máxima de hóspedes.
        /// </summary>
        public int Capacidade
        {
            get => capacidade;
            set => capacidade = value;
        }

        /// <summary>
        /// Valor da diária da suíte.
        /// </summary>
        public decimal ValorDiaria
        {
            get => valorDiaria;
            set => valorDiaria = value;
        }
    }
}