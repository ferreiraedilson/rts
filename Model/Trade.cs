using riskSystemTest.Interfaces;

namespace riskSystemTest.Model
{
    public class Trade : ITrade
    {
        public double Value { get; set; } 
        public string ClientSector { get; set; }
        public decimal TradeAmount { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public bool? PoliticalExposedPersonal { get; set; }
        public DateTime ReferenceDate { get; set; }
        public int RegisterCount { get; set; }
    }
}
