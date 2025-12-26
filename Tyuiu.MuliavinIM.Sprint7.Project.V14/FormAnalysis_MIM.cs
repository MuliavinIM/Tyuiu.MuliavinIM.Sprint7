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
        }

        // 🧾 Таблица
        private void buttonTable_MIM_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        // 📊 Анализ (по сути как "Назад")
        private void buttonAnalysis_MIM_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void buttonHelp_MIM_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
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

    }
}
