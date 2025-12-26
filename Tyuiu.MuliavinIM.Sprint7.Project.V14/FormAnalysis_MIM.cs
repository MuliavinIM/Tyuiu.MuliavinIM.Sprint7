using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Data;
using System.Windows.Forms;

namespace Tyuiu.MuliavinIM.Sprint7.Project.V14
{
    public partial class FormAnalysis_MIM : Form
    {
        private DataTable routesTable;
        private FormMain_MIM mainForm;

        public FormAnalysis_MIM(FormMain_MIM mainForm, DataTable table)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            routesTable = table;

            CalculateStatistics();
            UpdateChart_MIM();
        }


        private void buttonTable_MIM_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }


        private void buttonAnalysis_MIM_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }


        private void CalculateStatistics()
        {
            int totalRoutes = routesTable.Rows.Count;

            labelTotalRoutes_MIM.Text =
                $"Общее количество маршрутов: {totalRoutes}";

            if (totalRoutes == 0)
            {
                labelMinTime_MIM.Text = "Минимальное время в пути: -";
                labelMaxTime_MIM.Text = "Максимальное время в пути: -";
                labelAvgTime_MIM.Text = "Среднее время в пути: -";
                return;
            }

            List<double> times = new List<double>();

            foreach (DataRow row in routesTable.Rows)
            {
                if (double.TryParse(row["Время в пути"].ToString(), out double time))
                {
                    times.Add(time);
                }
            }

            if (times.Count == 0)
            {
                labelMinTime_MIM.Text = "Минимальное время в пути: -";
                labelMaxTime_MIM.Text = "Максимальное время в пути: -";
                labelAvgTime_MIM.Text = "Среднее время в пути: -";
                return;
            }

            labelMinTime_MIM.Text =
                $"Минимальное время в пути: {times.Min()}";

            labelMaxTime_MIM.Text =
                $"Максимальное время в пути: {times.Max()}";

            labelAvgTime_MIM.Text =
                $"Среднее время в пути: {Math.Round(times.Average(), 2)}";
        }
        private void UpdateChart_MIM()
        {
            var model = new PlotModel
            {
                Title = "Распределение маршрутов по времени в пути"
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Количество маршрутов",
                Minimum = 0,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Время в пути (мин)",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            };

            model.Axes.Add(valueAxis);
            model.Axes.Add(categoryAxis);

            var series = new BarSeries
            {
                Title = "Маршруты",
                FillColor = OxyColors.SkyBlue,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1,
                LabelPlacement = LabelPlacement.Outside
            };

            Dictionary<int, int> distribution = new Dictionary<int, int>();

            foreach (DataRow row in routesTable.Rows)
            {
                if (int.TryParse(row["Время в пути"]?.ToString(), out int time))
                {
                    if (!distribution.ContainsKey(time))
                        distribution[time] = 0;

                    distribution[time]++;
                }
            }

            foreach (var item in distribution.OrderBy(d => d.Key))
            {
                series.Items.Add(new BarItem { Value = item.Value });
                categoryAxis.Labels.Add(item.Key.ToString());
            }

            model.Series.Add(series);
            ChartRoutes_MIM.Model = model;
        }
        private void buttonHelp_MIM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик Мулявин Иван Михайлович \r\nгруппа ИСТНб-25-1\r\n\r\nТюменский Индустриальный Университет \r\nВысшая школа цифровых технологий\r\n\r\nВнутренне имя Tyuiu.MuliavinIM.Sprint7.Project.V14");
        }

        private void toolTip_MIM_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
