using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactorySample
{
    // 柱状图类
    class HistogramChart:IChart
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图");
        }
        
        public void Display()
        {
            Console.WriteLine("显示柱状图");
        }
    }
}
