using System;
using System.Configuration;

namespace SimpleFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            IChart chart;
            //读取配置文件
            string chartStr = ConfigurationManager.AppSettings["chartType"];
            chart = ChartFactory.GetChart(chartStr);    //通过静态工厂方法创建产品
            chart.Display();

            Console.ReadLine();
        }
    }
}
