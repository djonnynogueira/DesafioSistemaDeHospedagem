# Construindo um Sistema de Hospedagem de um Hotel no C#
#### DIO - Trilha .NET - Explorando a linguagem C#
##

#### Desafio: construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos. Seu programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

#### Diagrama de classes
<img alt="Diagrama de classes" src="https://raw.githubusercontent.com/digitalinnovationone/trilha-net-explorando-desafio/main/diagrama_classe_hotel.png" width=30% />

### Regras e validações

- Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception. 
- O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
- Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.