namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public string TypeSuite { get; set; }
        public int Capacity { get; set; }
        public decimal DiaryValue { get; set; }

        public Suite() { }

        public Suite(string typeSuite, int capacity, decimal diaryValue)
        {
            TypeSuite = typeSuite;
            Capacity = capacity;
            DiaryValue = diaryValue;
        }

    }
}