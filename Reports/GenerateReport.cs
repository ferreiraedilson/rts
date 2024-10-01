using riskSystemTest.Model;
using System.Text;

namespace riskSystemTest.Processing
{
    public abstract class GenerateReport
    {
        private string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
        protected string[] inputFile { get; set; }
        protected string[] outPutFile { get; set; }
        protected DateTime referenceDate;
        protected int registerCount;
        protected Trade trade = new Trade();
        protected List<Trade> ListTrade = new List<Trade>();
        protected string fileNameOutput { get; set; }
        public GenerateReport()
        {
            ImportTradeFile();
            ReadInputFile();
        }
        protected void ImportTradeFile()
        {
            string traderPath = Path.Combine(baseFolder, @"DataSource\tradeFile.csv");
            inputFile = File.ReadAllLines(traderPath);
        }
        protected void WriteTradeOutputFile()
        {
            string traderPath = Path.Combine(baseFolder, fileNameOutput);
            File.WriteAllLines(traderPath, outPutFile, Encoding.UTF8);
        }
        protected void CaptureHeader(string[] arrayData)
        {
            var headerValueDate = arrayData[0].Split("/");
            if (headerValueDate.Length > 1)
                referenceDate = Convert.ToDateTime(arrayData[0]);
            else
                registerCount = Convert.ToInt32(arrayData[0]);
        }
        protected List<Trade> ReadInputFile()
        {
            string[] arrayData;
            for (int i = 0; i < inputFile.Length; i++)
            {
                var line = inputFile[i];
                arrayData = line.ToString().Split(' ');
                if (arrayData.Length.Equals(1))
                    CaptureHeader(arrayData);
                else if (arrayData.Length > 1)
                {
                    CaptureBody(arrayData);
                    ListTrade.Add(trade);
                    trade = new Trade();
                }
            }
            return ListTrade;
        }
        protected abstract void CaptureBody(string[] arrayData);
        public abstract void GenerateOutput();

    }

}
