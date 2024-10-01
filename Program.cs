using riskSystem.Reports;
using riskSystemTest.Reports;


var outPutQuestion01 = ReportOutPutFactory.GetFactoryReport<Question01Report>();
outPutQuestion01.GenerateOutput();
Console.WriteLine("Output of Question 01 was created");
Console.WriteLine("");

var outPutQuestion02 = ReportOutPutFactory.GetFactoryReport<Question02Report>();
outPutQuestion02.GenerateOutput();
Console.WriteLine("Output of Question 02 was created");
Console.WriteLine("");

Console.WriteLine("Press any key to close this window");
Console.ReadKey();

