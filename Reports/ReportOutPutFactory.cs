using riskSystemTest.Processing;

namespace riskSystem.Reports
{
    public static class ReportOutPutFactory
    {
        public static T GetFactoryReport<T>() where T : GenerateReport, new()
        {
            return new T();
        }
    }
}
