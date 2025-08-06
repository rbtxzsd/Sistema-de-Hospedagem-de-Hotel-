using System.Collections;
using trilha_net_explorando_desafio.models;

List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa(nome:"Hospede", sobrenome:"1");
Pessoa p2 = new Pessoa(nome: "Hospede", sobrenome: "2");

hospedes.Add(p1);
hospedes.Add(p2);

Reserva reserva = new Reserva(diasReservados: 12);
Suite suite = new Suite("Casal", 2, 170);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

                          