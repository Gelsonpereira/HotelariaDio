using HotelariaDio.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

System.Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospede()}");
System.Console.WriteLine($"Hospedes: {reserva.CalcularValorDiaria()}");