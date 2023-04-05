namespace GeekBurguer.Contracts
{
    public class Production
    {
        public int ProductionId { get; set; }
        public string[] Restrictions { get; set; }
        public bool On { get; set; }
    }
}
