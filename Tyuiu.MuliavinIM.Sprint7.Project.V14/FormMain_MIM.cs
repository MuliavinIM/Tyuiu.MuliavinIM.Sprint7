using System.Data;
using System.Text;

namespace Tyuiu.MuliavinIM.Sprint7.Project.V14
{
    public partial class FormMain_MIM : Form
    {
        private DataTable routesTable;
        private BindingSource bindingSource;
        private bool editMode = false;

        public FormMain_MIM()
        {
            InitializeComponent();
            InitTable();
        }

        private void InitTable()
        {
            routesTable = new DataTable();

            routesTable.Columns.Add("Вид транспорта");
            routesTable.Columns.Add("Номер маршрута");
            routesTable.Columns.Add("Дата начала");
            routesTable.Columns.Add("Начальная остановка");
            routesTable.Columns.Add("Конечная остановка");
            routesTable.Columns.Add("Время в пути");

            bindingSource = new BindingSource();
            bindingSource.DataSource = routesTable;

            dataGridViewRoutes_MIM.AutoGenerateColumns = true;
            dataGridViewRoutes_MIM.DataSource = bindingSource;

            dataGridViewRoutes_MIM.AllowUserToAddRows = false;
            dataGridViewRoutes_MIM.ReadOnly = true;
        }

        private void buttonAddRoute_MIM_Click(object sender, EventArgs e)
        {
            routesTable.Rows.Add("", "", "", "", "", "");
        }

        private void buttonEditRoute_MIM_Click(object sender, EventArgs e)
        {
            editMode = true;
            dataGridViewRoutes_MIM.ReadOnly = false;
        }

        private void buttonDeleteRoute_MIM_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoutes_MIM.CurrentRow != null)
            {
                dataGridViewRoutes_MIM.Rows.RemoveAt(
                    dataGridViewRoutes_MIM.CurrentRow.Index
                );
            }
        }

        private void buttonSaveData_MIM_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in routesTable.Rows)
            {
                sb.AppendLine(string.Join(";", row.ItemArray));
            }

            File.WriteAllText(saveDialog.FileName, sb.ToString(), Encoding.UTF8);

            editMode = false;
            dataGridViewRoutes_MIM.ReadOnly = true;
        }

        private void buttonLoadData_MIM_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            routesTable.Rows.Clear();

            string[] lines = File.ReadAllLines(openDialog.FileName, Encoding.UTF8);

            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                routesTable.Rows.Add(values);
            }

            dataGridViewRoutes_MIM.ReadOnly = true;
        }

        private void buttonSearch_MIM_Click(object sender, EventArgs e)
        {
            string value = textBoxSearchRoute_MIM.Text.Trim();
            if (string.IsNullOrEmpty(value))
                return;

            bindingSource.Filter = $"[Номер маршрута] = '{value}'";
        }

        private void buttonResetSearch_MIM_Click(object sender, EventArgs e)
        {
            textBoxSearchRoute_MIM.Clear();
            bindingSource.RemoveFilter();
        }

        private void buttonAnalysis_MIM_Click(object sender, EventArgs e)
        {
            FormAnalysis_MIM analysisForm = new FormAnalysis_MIM(this, routesTable);
            analysisForm.Show();
            Hide();
        }

        private void buttonHelp_MIM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик Мулявин Иван Михайлович \r\nгруппа ИСТНб-25-1\r\n\r\nТюменский Индустриальный Университет \r\nВысшая школа цифровых технологий\r\n\r\nВнутренне имя Tyuiu.MuliavinIM.Sprint7.Project.V14");
        }
    }
}
