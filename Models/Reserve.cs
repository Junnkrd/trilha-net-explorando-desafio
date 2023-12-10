namespace DesafioProjetoHospedagem.Models
{
    public class Reserve
    {
        public List<Client> ClientsList { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reserve() { }

        public Reserve(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterClients(List<Client> clientsList)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
 try
    {
        if (Suite != null && Suite.Capacity >= clientsList.Count)
        {
            ClientsList = clientsList;
        }
        else
        {
            Console.WriteLine("Suite não comporta essa quantidade de pessoas.");
            // Outras ações de tratamento, se necessário
        }
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"Erro: {e.Message}");
        // Outras ações de tratamento, se necessário
    } 
          
        }

        public void CreatSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetClientsQuantity()
        {

            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return ClientsList.Count;
        }

        public decimal DiaryValueCalc()
        {


            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
        

            decimal value = 0;

         value =  ReservedDays * Suite.DiaryValue;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (ReservedDays >= 10)
            {
               value = value * 0.9m;
            }

            return value;
        }
    }
}