using riskSystemTest.Processing;

namespace riskSystemTest.Reports
{
    public class Question01Report : GenerateReport
    {
        public override void GenerateOutput()
        {
            this.fileNameOutput = "Question01_Report.csv";
            this.outPutFile = new string[this.ListTrade.Count()];
            var lineNumber = 0;
            foreach (var input in this.ListTrade)
            {
                if (input.NextPaymentDate < DateTime.Now.AddDays(-30))
                    this.outPutFile[lineNumber] = "EXPIRED";
                else if (input.ClientSector.Equals("Private") && (input.TradeAmount > 1000000))
                {
                    this.outPutFile[lineNumber] = "HIGHRISK";
                }
                else if (input.ClientSector.Equals("Public") && (input.TradeAmount > 1000000))
                {
                    this.outPutFile[lineNumber] = "MEDIUMRISK";
                }
                lineNumber++;
            }
            this.WriteTradeOutputFile();
        }

        protected override void CaptureBody(string[] arrayData)
        {            
            trade.ReferenceDate = referenceDate;
            trade.RegisterCount = registerCount;
            trade.TradeAmount = Convert.ToInt32(arrayData[0]);
            trade.ClientSector = arrayData[1];
            trade.NextPaymentDate = Convert.ToDateTime(arrayData[2]);
        }
    }
}
