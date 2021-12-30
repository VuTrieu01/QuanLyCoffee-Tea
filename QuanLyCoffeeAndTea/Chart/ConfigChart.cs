using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffeeAndTea.Chart
{
    class ConfigChart
    {
        public static ChartConfig Config()
        {
            ChartConfig config = new ChartConfig();
          
            Color foreColor = Color.Black;
            List<Color> colors = new List<Color>()
            {
                Color.Green
                
            };
            List <Color> colorsPoint = new List<Color>()
            {
                Color.FromArgb(84, 193, 254)
            };

            var chartFont = new ChartFont()
            {
                FontName = "Segoe UI",
                Size = 12,
                Style = ChartFontStyle.Bold
            };

            config.Title.ForeColor = foreColor;

            config.Legend.LabelFont = chartFont;
            config.Legend.LabelForeColor = foreColor;

            config.XAxes.Ticks.Font = chartFont;
            config.XAxes.Ticks.ForeColor = foreColor;

            config.YAxes.Ticks.Font = chartFont;
            config.YAxes.Ticks.ForeColor = foreColor;

            config.ZAxes.Ticks.Font = chartFont;
            config.ZAxes.Ticks.ForeColor = foreColor;
            config.ZAxes.PointLabels.Font = chartFont;
            config.ZAxes.PointLabels.ForeColor = foreColor;

            config.PaletteCustomColors.FillColors.AddRange(colors);
            config.PaletteCustomColors.BorderColors.AddRange(colors);
            config.PaletteCustomColors.PointFillColors.AddRange(new List<Color>() { Color.FromArgb(229, 9, 20) });
            config.PaletteCustomColors.PointBorderColors.AddRange(colorsPoint);

            return config;
        }
    }
}
