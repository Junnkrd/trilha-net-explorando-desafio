namespace DesafioProjetoHospedagem.Models;

public class Client
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string CompleteName => $"{Name} {Surname}".ToUpper();
    public Client() { }

    public Client(string name)
    {
        Name = name;
    }

    public Client(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

}