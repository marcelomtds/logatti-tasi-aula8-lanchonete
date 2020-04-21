namespace Model
{
    public class Lanchonete
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int QuantidadeClientes { get; set; }

        public int NumeroEmpregados { get; set; }

        public double TotalReceita { get; set; }

        public double TotalDespesa { get; set; }
    }
}
