using riskSystem.Reports;
using riskSystemTest.Reports;

var outPutQuestion01 = ReportOutPutFactory.GetFactoryReport<Question01Report>();
outPutQuestion01.GenerateOutput();

var outPutQuestion02 = ReportOutPutFactory.GetFactoryReport<Question02Report>();
outPutQuestion02.GenerateOutput();