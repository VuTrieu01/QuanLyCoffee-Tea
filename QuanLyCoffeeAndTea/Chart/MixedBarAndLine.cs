using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffeeAndTea.Chart
{
    class MixedBarAndLine
    {
        public static List<double> revenue;
        public static void loadChart(Guna.Charts.WinForms.GunaChart chart, string type)
        {
            List<string> dayOfWeek = new List<string>();
            int index = 6;
            while (index >= 0)
                dayOfWeek.Add(DateTime.Today.AddDays(-index--).DayOfWeek.ToString());

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

                var dataset = new GunaBarDataset();
                dataset.Label = "Doanh thu";
                for (int i = 0; i < dayOfWeek.Count; i++)
                    dataset.DataPoints.Add(dayOfWeek[i], revenue[i]);
                chart.Datasets.Add(dataset);
            

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
