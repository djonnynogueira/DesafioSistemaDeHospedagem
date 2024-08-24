using DesafioSistemaDeHospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "José");
Pessoa p2 = new Pessoa(nome: "Maria");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

//Cria uma nova reserva, passando a suite e os hóspedes
Reserva reserva = new Reserva(diasReservados: 50);
reserva.CadastrarSuites(suite);
reserva.CadastrarHospedes(hospedes);

//Quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Nome dos Hóspedes:");
foreach (var p in reserva.ObertHospedes())
{
    Console.WriteLine($"- {p}");
}
Console.WriteLine($"Valor da diária: R${reserva.CalcularValorDiaria():F2}");