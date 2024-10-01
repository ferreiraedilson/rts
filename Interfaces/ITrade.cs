namespace riskSystemTest.Interfaces
{
    interface ITrade
    {        
        double Value { get; set; }
        string ClientSector { get; set; }
        DateTime NextPaymentDate { get; set; }
        decimal TradeAmount { get; set; }
        bool? PoliticalExposedPersonal { get; set; }
        DateTime ReferenceDate { get; set; }
        int RegisterCount { get; set; }
    }

}
