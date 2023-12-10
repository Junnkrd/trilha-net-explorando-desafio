using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Client> clientsList = new List<Client>();

Client p1 = new Client(name: "Hóspede 1");
Client p2 = new Client(name: "Hóspede 2");

clientsList.Add(p1);
clientsList.Add(p2);

// Cria a suíte
Suite suite = new Suite(typeSuite: "Premium", capacity: 2, diaryValue: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserve reserve = new Reserve(reservedDays: 10);
reserve.CreatSuite(suite);
reserve.RegisterClients(clientsList);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserve.GetClientsQuantity()}");
Console.WriteLine($"Valor diária: {reserve.DiaryValueCalc()}");