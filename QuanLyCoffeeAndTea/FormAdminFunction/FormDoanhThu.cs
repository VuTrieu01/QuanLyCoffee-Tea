using QuanLyCoffeeAndTea.Chart;
using QuanLyCoffeeAndTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffeeAndTea.FormAdminFunction
{
    public partial class FormDoanhThu : Form
    {
        CoffeeAndTeaContextDB contextDB = new CoffeeAndTeaContextDB();
        private List<double> arr = new List<double>();
        private string revenueMonth, revenueYear;
        private int month = 0, year = 0;
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private int getMonth(DateTime date)
        {
            return date.Month;
        }

        private int getYear(DateTime date)
        {
            return date.Year;
        }

        private void loadData(int month, int year)
        {
            double money = 0;
            int day = 6, number = 0,  totalNumber = 0;
            DateTime startDate;

            var query = contextDB.HOADONs;

            while(day >= 0)
            {
                startDate = DateTime.Today.AddDays(-day--).Date;
                var result = query.Where(x => DbFunctions.TruncateTime(x.NgayHD) == startDate);
                money = Convert.ToDouble(result.Sum(x => x.ThanhTien));
                number = result.Count();
                totalNumber += number;
                arr.Add(money);
            };

            revenueMonth = query.AsEnumerable().Where(x => getMonth(x.NgayHD) == month)
                .Sum(x => x.ThanhTien).ToString() + "VNĐ";
            revenueYear = query.AsEnumerable().Where(x => getYear(x.NgayHD) == year)
                .Sum(x => x.ThanhTien).ToString() + " VNĐ";
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            loadData(month, year);
            chart.ApplyConfig(ConfigChart.Config(), Color.White);
            MixedBarAndLine.revenue = arr;
            MixedBarAndLine.loadChart(chart, "bar");
            lblMoneyMonth.Text = revenueMonth;
            lblMoneyYear.Text = revenueYear;
            lblMonth.Text = "Doanh thu trong tháng " + month;
            lblYear.Text = "Doanh thu trong năm " + year;
        }
    }
}
